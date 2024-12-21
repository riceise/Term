using System.Data;
using Dapper;
using Data;
using Data.Model.Entities.UploadedFile;
using Data.Model;
using OfficeOpenXml;
using Microsoft.EntityFrameworkCore; 
using System.Text.Json;

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

        public async Task<string> GetInvoiceFileTypeAsync(int invoiceFileTypeId)
        {
            var query = "SELECT FileType FROM InvoiceFileTypes WHERE Id = @invoiceFileTypeId";

            return await _dbConnection.QueryFirstOrDefaultAsync<string>(query, new { invoiceFileTypeId });
        }

        public async Task<int> GetInvoiceIdFromZAPAsync(string Name, string LastName, DateTime BirthDay, string snils)
        {
            var query = "SELECT InvoiceId FROM ZAP WHERE Name1 = @Name AND Surname = @LastName AND Birthday = @BirthDay AND SNILS = @snils";

            return await _dbConnection.QueryFirstOrDefaultAsync<int>(query, new { Name, LastName, BirthDay, snils });
        }
        
        public async Task<int> GetInvoiceFileTypeId(int InvoceId)
        {
            var query = "SELECT invoiceFileTypeId FROM Invoices WHERE Id = @InvoceId";

            return await _dbConnection.QueryFirstOrDefaultAsync<int>(query, new { InvoceId });
        }

        public async Task<bool> CheckPersonExistsAsync(string Name, string LastName, DateTime BirthDay, string snils)
        {
            var query = "SELECT COUNT(1) FROM Persons WHERE Name1 = @Name AND Surname = @LastName AND Birthday = @BirthDay AND SNILS = @snils";

            return await _dbConnection.ExecuteScalarAsync<bool>(query, new { Name, LastName, BirthDay, snils });
        }

        public async Task<IEnumerable<SpiskiNaDDFromMO>> GetSpiskiAsync(int uploadFileInfId)
        {
            var query = "SELECT * FROM SpiskiNaDDFromMO WHERE UploadFileInfId = @uploadFileInfId";

            return await _dbConnection.QueryAsync<SpiskiNaDDFromMO>(query, new { uploadFileInfId });
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
                // const string insertQuery = @"
                //     INSERT INTO DispensaryListResults 
                //     (SpiskiNaDDFromMOId, SourceMOCode, SourceMOName, LastName, Name, Patronymic, BirthDay, 
                //      Snils, Period, Organization, ProcessingDate, DispensaryRegistrationStatus, DateLastDD, 
                //      DispensaryGroup, RegisteredMOCode, RegisteredMOName, AttachmentMOCode, AttachmentMOName, ProcessingResult)
                //     VALUES 
                //     (@SpiskiNaDDFromMOId, @SourceMOCode, @SourceMOName, @LastName, @Name, @Patronymic, @BirthDay, 
                //      @Snils, @Period, @Organization, @ProcessingDate, @DispensaryRegistrationStatus, @DateLastDD, 
                //      @DispensaryGroup, @RegisteredMOCode, @RegisteredMOName, @AttachmentMOCode, @AttachmentMOName, @ProcessingResult)";

                const string insertQuery = @"
                    INSERT INTO DispansaryListResults 
                    (SpiskiNaDDFromMOId, SourceMOCode, SourceMOName, LastName, Name, Patronymic, BirthDay, 
                     Snils, Period, Organization, ProcessingDate, DateLastDD, AttachmentMOCode, AttachmentMOName, ProcessingResult)
                    VALUES 
                    (@SpiskiNaDDFromMOId, @SourceMOCode, @SourceMOName, @LastName, @Name, @Patronymic, @BirthDay, 
                     @Snils, @Period, @Organization, @ProcessingDate, @DateLastDD, @AttachmentMOCode, @AttachmentMOName, @ProcessingResult)";

                var currentYear = DateTime.Now.Year; 

                foreach (var result in results)
                {
                    bool personExist = await CheckPersonExistsAsync(result.Name, result.LastName, result.BirthDay, result.Snils);

                    if (!personExist)
                    {
                        result.ProcessingResult = "Неидентифицирован";
                    }
                    else
                    {
                        var InvoiceId = await GetInvoiceIdFromZAPAsync(result.Name, result.LastName, result.BirthDay, result.Snils);
                        
                        if(InvoiceId != 0)
                        {
                            var invoiceFileTypeId = await GetInvoiceFileTypeId(InvoiceId);
                            var fileType = await GetInvoiceFileTypeAsync(invoiceFileTypeId);
                            var dateLastDD = await GetZapDateDnAsync(result.Snils);

                            if (fileType == "DP")
                            {
                                if (dateLastDD != null && dateLastDD.Value.Year == currentYear)
                                {
                                    result.ProcessingResult = "Ок. Проведена ДДвзр в текущем году";
                                }
                                else
                                {
                                    result.ProcessingResult = "Нет ДДвзр в текущем году";
                                }
                            }
                            else if (fileType == "DO")
                            {
                                if (dateLastDD != null && dateLastDD.Value.Year == currentYear)
                                {
                                    result.ProcessingResult = "Ок. Проведен ПрофОсмотрВзр в текущем году";
                                }
                                else
                                {
                                    result.ProcessingResult = "Нет ПрофОсмотрВзр в текущем году";
                                }
                            }
                        }
                        else
                        {
                            result.ProcessingResult = "Нет ДДвзр и ПрофОсмотрВзр в текущем году";
                        }
                    }

                    Console.WriteLine("Вставляемые данные:");
                    Console.WriteLine($"  SpiskiNaDDFromMOId: {result.SpiskiNaDDFromMOId}");
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
                var query = @"SELECT * FROM DispensaryListResults WHERE SpiskiNaDDFromMOId IN 
                                          (SELECT Id FROM SpiskiNaDDFromMO WHERE UploadFileInfId = @uploadFileInfId)";
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
                .Include(r => r.SpiskiNaDDFromMO) 
                .Where(r => r.SpiskiNaDDFromMO.UploadFileInfId == uploadFileInfId)
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
                    worksheet.Cells[row, 12].Value = result.AttachmentMOCode;
                    worksheet.Cells[row, 13].Value = result.AttachmentMOName;
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

