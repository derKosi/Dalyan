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
    
    public class ProductAddQuery : IQuery<Dalyan.Entities.Models.Product>
    {
    	public Dalyan.Entities.Models.Product Product{ get; set; }
    }
    
    public class ProductAddQueryHandler : IQueryHandler<ProductAddQuery,Dalyan.Entities.Models.Product>
    {
    	private readonly DbEntities _db;
    	public ProductAddQueryHandler()
    	{
    		_db = new DbEntities();
    	}
    
    	    
    	public Dalyan.Entities.Models.Product Handler(ProductAddQuery query)
    	{
    		try
    		{
    			var obj = new Dalyan.Db.Product();
    			obj.Id = query.Product.Id;
    			obj.CompanyId = query.Product.CompanyId;
    			obj.Name = query.Product.Name;
    			obj.Description = query.Product.Description;
    			obj.Price = query.Product.Price;
    			obj.CreatedDate = query.Product.CreatedDate;
    			obj.CreatedIpAddress = query.Product.CreatedIpAddress;
    			obj.CreatedUserId = query.Product.CreatedUserId;
    			obj.UpdatedDate = query.Product.UpdatedDate;
    			obj.UpdatedIpAddress = query.Product.UpdatedIpAddress;
    			obj.UpdatedUserId = query.Product.UpdatedUserId;
    			obj.IsDeleted = query.Product.IsDeleted;
    			_db.Product.Add(obj);
    			_db.SaveChanges();
    			query.Product.Id = obj.Id;
    			return query.Product;
    
    		}
    		catch (Exception ex)
    		{
    			throw new ExceptionLog(LogType.DATABASE_INSERT, LogLevel.ERROR, ex, "AddQueryHandler");
    		}
    	}
    }
    
    
}
