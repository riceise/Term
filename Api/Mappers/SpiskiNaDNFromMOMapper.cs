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
        
    }
}

