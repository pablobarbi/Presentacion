
using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.Dto;
using WebApi.EF.Models;
using WebApi.Repo;

namespace WebApi.Manager
{
    public class StoresManager : RepositoryBase<Stores>
    {
        public List<StoresDto> GetAll()
        {
            var lstStores = this.All().ToList();
            var lista = new List<StoresDto>();
            return ListDto(lstStores); 
        }
        public StoresDto GetById(int id)
        {
            var store = this.All().Where( s=>s.Id == id).FirstOrDefault();
            return Dto(store);
        }
 

        public void Add( StoresDto store)
        {            
            this.Create(Entity(store));
        }
        public void Upd(StoresDto store)
        {
            this.Update(Entity(store));
        }
        public void Del(StoresDto store)
        {
            this.Delete(Entity(store));
        }


        #region Mapper
        private List<StoresDto> ListDto( List<Stores> listStore)
        {
            return listStore.Select(s => new StoresDto()
            {
                 Address = s.Address,
                 Id = s.Id,
                 Name  =s.Name
            }).ToList();
        }

        private StoresDto Dto(Stores store)
        {
            return new StoresDto()
            {
                Address = store.Address,
                Id = store.Id,
                Name = store.Name
            };
        }

        private Stores Entity(StoresDto storeDto)
        {
            return new Stores()
            {
                Address = storeDto.Address,
                Id = storeDto.Id,
                Name = storeDto.Name
            };
        }
        #endregion
    }
}
