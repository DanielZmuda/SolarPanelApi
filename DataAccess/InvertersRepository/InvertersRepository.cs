
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;


namespace DataAccess.DbContexts
{
    public class InvertersRepository : Repository<Inverter>, IInvertersRepository
    {
        public readonly SolarInstalationDbContext _context;

        public InvertersRepository(SolarInstalationDbContext context): base(context)
        {
            _context = context;
        }
        //public IEnumerable<Inverter> GetInverters(string manufacturer, string searchQuery)
        //{
        //    if (string.IsNullOrWhiteSpace(manufacturer)
        //        && string.IsNullOrWhiteSpace(searchQuery))
        //    {
        //        return GetInverters();
        //    }

        //    var collection = _context.Inverter as IQueryable<Inverter>;

        //    if (!string.IsNullOrWhiteSpace(manufacturer))
        //    {
        //        manufacturer = manufacturer.Trim();
        //        return _context.Inverter.Where(a => a.Manufacturer == manufacturer).ToList();

        //    }

        //    if (!string.IsNullOrWhiteSpace(searchQuery))
        //    {
        //        searchQuery = searchQuery.Trim();
        //        collection = collection.Where(a => a.Manufacturer.Contains(searchQuery)
        //        || a.Name.Contains(searchQuery));
        //    }

        //    return collection.ToList();
        //}

        //public Inverter GetInverter(Guid Id)
        //{
        //    return _context.Inverter.Where(a => a.Id == Id).FirstOrDefault();
        //}



        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }
 
    }
}
