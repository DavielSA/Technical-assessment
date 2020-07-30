using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using TechnicalAssessment.Repository;
using TechnicalAssessment.Model;
using System.Transactions;

namespace TechnicalAssessment.Service.impl
{
    public class HolidayHomeService : IHolidayHomeService
    {

        private readonly IHolidayHomeRepository _repository;
        private readonly IHolidayHomeLangRepository _repositoryLang;
        private readonly IHolidayHomeFreeDayInterface _repositoryFreeDay;
        private readonly IOwnerRepository _repositoryOwner;

        public HolidayHomeService(
            IHolidayHomeRepository repo, 
            IHolidayHomeLangRepository repoLang, 
            IHolidayHomeFreeDayInterface repoFreeDay, 
            IOwnerRepository repoOwner
        ) {
            this._repository = repo;
            this._repositoryLang = repoLang;
            this._repositoryFreeDay = repoFreeDay;
            this._repositoryOwner = repoOwner;
        }
        

        public bool Delete(int id)
        {
            this._repository.Delete(id);
            HolidayHome exist = this._repository.FindById(id);
            return exist == null
                ? true
                : false;
        }

        public List<RespHolidayHome> Get()
        {
            List<HolidayHome> hh = this._repository.FindAll().ToList<HolidayHome>();

            List<RespHolidayHome> resp = (
                from c
                in hh
                select new RespHolidayHome()
                {
                    Id = c.Id,
                    Owner = this._repositoryOwner.FindById(c.OwnerId),
                    Alias = c.Alias,
                    Langs = this._repositoryLang.Find(c.Id).ToList<HolidayHomeLang>(),
                    FreeDay = this._repositoryFreeDay.Find(c.Id).ToList<HolidayHomeFreeDay>()
                }
            ).ToList<RespHolidayHome>();

            return resp;
        }

        public RespHolidayHome Get(int id)
        {
            HolidayHome hh = this._repository.FindById(id);
            if (hh == null)
                return null;

            return new RespHolidayHome()
            {
                Id = hh.Id,
                Owner = this._repositoryOwner.FindById(hh.OwnerId),
                Alias = hh.Alias,
                Langs = this._repositoryLang.Find(hh.Id).ToList<HolidayHomeLang>(),
                FreeDay = this._repositoryFreeDay.Find(hh.Id).ToList<HolidayHomeFreeDay>()
            };
        }

        public HolidayHome Save(HolidayHome entity)
        {
            HolidayHome saved = null;
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    this._repository.Insert(entity);
                    scope.Complete();
                    saved = this._repository.Find(entity);
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
            }
            return saved;
        }

        public HolidayHome Update(int id, HolidayHome entity)
        {
            HolidayHome saved = null;

            if (entity != null)
            {
                using (var scope = new TransactionScope())
                {
                    try
                    {
                        this._repository.Update(entity);
                        scope.Complete();
                        saved = this._repository.Find(entity);
                    } catch (Exception e)
                    {
                        System.Console.WriteLine(e.Message);
                    }
                }
            }
            return saved;
        }

        List<HolidayHome> IGenericService<HolidayHome>.Get()
        {
            throw new NotImplementedException();
        }

        HolidayHome IGenericService<HolidayHome>.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
