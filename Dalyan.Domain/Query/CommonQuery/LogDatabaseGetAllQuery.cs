//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dalyan.Domain.Query
{
    using System;
    using Dalyan.Domain;
    using System.Linq;
    using System.Text;
    using Dalyan.Domain.Query;
    using System.Data;
    using System.Xml;
    using Dalyan.Db;
    using Entities.Models;
    using Dalyan.Entities.Enumerations;
    using AutoMapper;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    
    public class LogDatabaseGetAllQuery : IQuery<IList<Dalyan.Entities.Models.LogDatabase>>
    {
    	
    }
    
    public class LogDatabaseGetAllQueryHandler : IQueryHandler<LogDatabaseGetAllQuery, IList<Dalyan.Entities.Models.LogDatabase>>
    {
    	private readonly DbEntities _db;
    	public LogDatabaseGetAllQueryHandler()
    	{
    		_db = new DbEntities();
    	}
    
    	    
    	public IList<Dalyan.Entities.Models.LogDatabase> Handler(LogDatabaseGetAllQuery query)
    	{
    		try
    		{
    			var result = _db.LogDatabase.Include("User").Where(x => x.IsDeleted == false).AsEnumerable().ToList();
    			Mapper.CreateMap<Dalyan.Db.User, Dalyan.Entities.Models.User>();
    			Mapper.CreateMap<Dalyan.Db.LogDatabase, Dalyan.Entities.Models.LogDatabase>().ForMember(c => c.User, d => d.MapFrom(s => s.User));
    			return Mapper.Map<IEnumerable<Dalyan.Db.LogDatabase>, IEnumerable<Dalyan.Entities.Models.LogDatabase>>(result).ToList();
    
    		}
    		catch (Exception ex)
    		{
    			throw new ExceptionLog(LogType.DATABASE_SELECT, LogLevel.ERROR, ex, "GetAllQueryHandler");
    		}
    	}
    }
    
}
