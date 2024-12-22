using System.Data;
using Dapper;
using Data;
using Data.Model.Entities.UploadedFile;
using Data.Model;
using OfficeOpenXml;
using Microsoft.EntityFrameworkCore; 
using System;
using System.Text.Json;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;


namespace Api.Repositories
{
    public class DispensaryListRepository : IDispensaryListRepository
    {
        private readonly IDbConnection _dbConnection;
        private readonly TFOMSContext _context;


        public DispensaryListRepository(IDbConnection dbConnection, TFOMSContext context)
        {
            _dbConnection = dbConnection;
            _context = context;
        }

        public async Task<IEnumerable<SpiskiNaDNFromMO>> GetSpiskiAsync(int uploadFileInfId)
        {
            var query = "SELECT * FROM SpiskiNaDNFromMO WHERE UploadFileInfId = @uploadFileInfId";
            return await _dbConnection.QueryAsync<SpiskiNaDNFromMO>(query, new { uploadFileInfId });
        }

        public async Task<string> GetMedicalCompanyShortNameAsync(string code)
        {
            var query = "SELECT ShortName FROM LPU.MedicalCompanies WHERE Code = @code";
            var result = await _dbConnection.QueryFirstOrDefaultAsync<string>(query, new { code });

            if (string.IsNullOrEmpty(result))
            {
                Console.WriteLine($"GetMedicalCompanyShortNameAsync: Не найден ShortName для кода {code}");
            }
            Console.WriteLine(result);
            return result;
        }

        
        public async Task<bool> CheckIfExistsInZapAsync(string snils)
        {
            var query = "SELECT COUNT(1) FROM ZAP WHERE SNILS = @snils";
            return await _dbConnection.ExecuteScalarAsync<bool>(query, new { snils });
        }

        public async Task<DateTime?> GetZapDateDnAsync(string snils)
        {
            var query = "SELECT TOP 1 DateDN FROM ZAP WHERE SNILS = @snils ORDER BY DateDN DESC";
            return await _dbConnection.QueryFirstOrDefaultAsync<DateTime?>(query, new { snils });
        }

        public async Task<string?> GetDispensaryGroupAsync(string snils)
        {
            try
            {
                var query = @"SELECT TOP 1 DiagnosisCode FROM DispensaryObservation DO
                          INNER JOIN ZAP Z ON DO.ZAPId = Z.Id WHERE Z.SNILS = @snils";

                    return await _dbConnection.QueryFirstOrDefaultAsync<string>(query, new { snils });
            }
            catch
            {
                Console.WriteLine("GetDispensaryGroupAsync несработал");
                return null;
            }
        }

        public async Task<IEnumerable<DispensaryObservation>> GetDispensaryObservationsAsync(string snils)
        {
            try
            {
                var query = @"SELECT DO.* FROM DispensaryObservation DO
                                          INNER JOIN ZAP Z ON DO.ZAPId = Z.Id WHERE Z.SNILS = @snils";
                            return await _dbConnection.QueryAsync<DispensaryObservation>(query, new { snils });
            }
            catch 
            {
                Console.WriteLine("GetDispensaryObservationsAsync не сработал");
                throw;
            }
            
        }
        
        public async Task SaveDispensaryListResultsAsync(IEnumerable<DispensaryListResult> results)
        {
            try
            {
                const string insertQuery = @"
                    INSERT INTO DispensaryListResults 
                    (SpiskiNaDnFromMoId, SourceMOCode, SourceMOName, LastName, Name, Patronymic, BirthDay, 
                     Snils, Period, Organization, ProcessingDate, DispensaryRegistrationStatus, DateLastDD, 
                     DispensaryGroup, RegisteredMOCode, RegisteredMOName, AttachmentMOCode, AttachmentMOName, ProcessingResult)
                    VALUES 
                    (@SpiskiNaDnFromMoId, @SourceMOCode, @SourceMOName, @LastName, @Name, @Patronymic, @BirthDay, 
                     @Snils, @Period, @Organization, @ProcessingDate, @DispensaryRegistrationStatus, @DateLastDD, 
                     @DispensaryGroup, @RegisteredMOCode, @RegisteredMOName, @AttachmentMOCode, @AttachmentMOName, @ProcessingResult)";

                var currentYear = DateTime.Now.Year;

                foreach (var result in results)
                {
                    var existsInZap = await CheckIfExistsInZapAsync(result.Snils);

                    if (!existsInZap)
                    {
                        result.ProcessingResult = "Неидентифицированы";
                        result.AttachmentMOCode = null;
                        result.AttachmentMOName = "";
                        result.RegisteredMOCode = null;
                        result.RegisteredMOName = "";
                        result.DispensaryGroup = "";
                        result.DateLastDD = null;
                    }
                    else if (result.DateLastDD.HasValue && result.DateLastDD.Value.Year == currentYear)
                    {
                        result.ProcessingResult = "Ок. Проведена ДДвзр в текущем году";
                    }
                    else
                    {
                        result.ProcessingResult = "Нет первого ДД и ПМО в текущем году";
                    }

                    Console.WriteLine("Вставляемые данные:");
                    Console.WriteLine($"  SpiskiNaDnFromMoId: {result.SpiskiNaDnFromMoId}");
                    Console.WriteLine($"  SourceMOCode: {result.SourceMOCode}");
                    Console.WriteLine($"  SourceMOName: {result.SourceMOName}");
                    Console.WriteLine($"  LastName: {result.LastName}");
                    Console.WriteLine($"  Name: {result.Name}");
                    Console.WriteLine($"  Patronymic: {result.Patronymic}");
                    Console.WriteLine($"  BirthDay: {result.BirthDay}");
                    Console.WriteLine($"  Snils: {result.Snils}");
                    Console.WriteLine($"  Period: {result.Period}");
                    Console.WriteLine($"  AttachmentMoCode: {result.AttachmentMOCode}");
                    Console.WriteLine($"  AttachmentMoName: {result.AttachmentMOName}");
                    Console.WriteLine($"  DispensaryRegistrationStatus: {result.DispensaryRegistrationStatus}");
                    Console.WriteLine($"  RegisteredMOCode: {result.RegisteredMOCode}");
                    Console.WriteLine($"  RegisteredMOName: {result.RegisteredMOName}");
                    Console.WriteLine($"  DispensaryGroup: {result.DispensaryGroup}");
                    Console.WriteLine($"  Organization: {result.Organization}");
                    Console.WriteLine($"  ProcessingResult: {result.ProcessingResult}");
                    Console.WriteLine($"  DateLastDD: {result.DateLastDD}");
                    Console.WriteLine($"  ProcessingDate: {result.ProcessingDate}");
                }

                Console.WriteLine($"Вставляемые данные (JSON): {JsonSerializer.Serialize(results)}");

                await _dbConnection.ExecuteAsync(insertQuery, results);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"SaveDispensaryListResultsAsync не сработал: {ex.Message}");
                throw;
            }
        }

        public async Task<IEnumerable<DispensaryListResult>> GetDispensaryListResultsAsync(int uploadFileInfId)
        {
            try
            {
                var query = @"SELECT * FROM DispensaryListResults WHERE SpiskiNaDnFromMoId IN 
                                          (SELECT Id FROM SpiskiNaDNFromMO WHERE UploadFileInfId = @uploadFileInfId)";
                            return await _dbConnection.QueryAsync<DispensaryListResult>(query, new { uploadFileInfId });
            }
            catch (Exception e)
            {
                Console.WriteLine("GetDispensaryListResultsAsync не сработал");
                Console.WriteLine(e);
                throw;
            }
            
        }

        public async Task<byte[]> GenerateExcelFileAsync(int uploadFileInfId)
        {
            var results = await _context.DispensaryListResults
                .Include(r => r.SpiskiNaDNFromMO) 
                .Where(r => r.SpiskiNaDNFromMO.UploadFileInfId == uploadFileInfId)
                .ToListAsync();

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Results");
                
                worksheet.Cells["A1"].Value = "Код МО источник списка";
                worksheet.Cells["B1"].Value = "МО источник списка";
                worksheet.Cells["C1"].Value = "Фамилия";
                worksheet.Cells["D1"].Value = "Имя";
                worksheet.Cells["E1"].Value = "Отчество";
                worksheet.Cells["F1"].Value = "Дата рождения";
                worksheet.Cells["G1"].Value = "СНИЛС";
                worksheet.Cells["H1"].Value = "Период";
                worksheet.Cells["I1"].Value = "Код МО Прикрепления";
                worksheet.Cells["J1"].Value = "МО Прикрепления";
                worksheet.Cells["K1"].Value = "Состоит/не состоит на ДН";
                worksheet.Cells["L1"].Value = "Код МО, в которой пациент состоит на ДН";
                worksheet.Cells["M1"].Value = "МО, в которой пациент состоит на ДН";
                worksheet.Cells["N1"].Value = "Диспансерная группа";
                worksheet.Cells["O1"].Value = "Организация";
                worksheet.Cells["P1"].Value = "Результат обработки ТФОМС";
                worksheet.Cells["Q1"].Value = "Дата прохождения ДН";
                worksheet.Cells["R1"].Value = "Дата обработки(Актуальность)";

                int row = 2;

                foreach (var result in results)
                {
                    worksheet.Cells[row, 1].Value = result.SourceMOCode;
                    worksheet.Cells[row, 2].Value = result.SourceMOName;
                    worksheet.Cells[row, 3].Value = result.LastName;
                    worksheet.Cells[row, 4].Value = result.Name;
                    worksheet.Cells[row, 5].Value = result.Patronymic;
                    worksheet.Cells[row, 6].Value = result.BirthDay.ToString("dd.MM.yyyy") ?? "";
                    worksheet.Cells[row, 7].Value = result.Snils;
                    worksheet.Cells[row, 8].Value = result.Period;
                    worksheet.Cells[row, 9].Value = result.RegisteredMOCode?.ToString() ?? "";
                    worksheet.Cells[row, 10].Value = result.RegisteredMOName;
                    worksheet.Cells[row, 11].Value = result.DispensaryRegistrationStatus;
                    worksheet.Cells[row, 12].Value = result.AttachmentMOCode;
                    worksheet.Cells[row, 13].Value = result.AttachmentMOName;
                    worksheet.Cells[row, 14].Value = result.DispensaryGroup;
                    worksheet.Cells[row, 15].Value = result.Organization;
                    worksheet.Cells[row, 16].Value = result.ProcessingResult;
                    worksheet.Cells[row, 17].Value = result.DateLastDD?.ToString("dd.MM.yyyy") ?? "";
                    worksheet.Cells[row, 18].Value = result.ProcessingDate.ToString("dd.MM.yyyy") ?? "";
                    
                    row++;
                }

                return package.GetAsByteArray();
            }
        }
    }
}

