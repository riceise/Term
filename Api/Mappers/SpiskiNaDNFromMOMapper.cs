using Share.DTOs;
using Data.Model.Entities.UploadedFile;

namespace Api.Mappers
{
    public static class SpiskiNaDNFromMOMapper
    {
        public static IEnumerable<SpiskiNaDNFromMO> MapDtoToEntity(IEnumerable<SpiskiNaDNFromMODTO> filesDto)
        {
            return filesDto.Select(fileDto => new SpiskiNaDNFromMO()
            {
                Npp = fileDto.Npp,
                LastName = fileDto.LastName,
                Name = fileDto.Name,
                Patronymic = fileDto.Patronymic,
                BirthDay = fileDto.BirthDay,
                Snils = fileDto.Snils,
                N_reest = fileDto.N_reest,
                Period = fileDto.Period,
                Organizaciya = fileDto.Organizaciya
            });
        }
        public static SpiskiNaDNFromMODTO MapEntityToDto(SpiskiNaDNFromMO entity)
        {
            return new SpiskiNaDNFromMODTO
            {
                Id = entity.Id,
                Npp = entity.Npp,
                LastName = entity.LastName,
                Name = entity.Name,
                Patronymic = entity.Patronymic,
                BirthDay = entity.BirthDay,
                Snils = entity.Snils,
                N_reest = entity.N_reest,
                Period = entity.Period,
                Organizaciya = entity.Organizaciya
            };
        }
        public static UploadFileInf MapToEntity(UploadFileInfoDTO dto)
        {
            return new UploadFileInf
            {
                UserId = dto.UserId,
                FileName = dto.FileName,
                FilePath = dto.FilePath,
                UploadDate = dto.UploadDate,
                UploadStatus = dto.UploadStatus
            };
        }

        public static UploadFileInfoDTO MapToDTO(UploadFileInf entity)
        {
            return new UploadFileInfoDTO
            {
                UserId = entity.UserId,
                FileName = entity.FileName,
                FilePath = entity.FilePath,
                UploadDate = entity.UploadDate,
                UploadStatus = entity.UploadStatus
            };
        }
        
        public static FileDTOView MapToDto(UploadFileInf file)
        {
            return new FileDTOView
            {
                Id = file.Id,
                FileName = file.FileName,
                UploadDate = file.UploadDate
            };
        }
        
        public static IEnumerable<FileDTOView> MapToDtoList(IEnumerable<UploadFileInf> files)
        {
            return files.Select(file => MapToDto(file)).ToList();
        }
    }
}

