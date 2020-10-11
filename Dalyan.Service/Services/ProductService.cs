//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dalyan.Service.Services
{
    using System;
    using SimpleInjector;
    using Dalyan.Domain;
    using Entities.Contracts;
    using System.Linq;
    using System.Text;
    using Dalyan.Entities.Interfaces;
    using Dalyan.Domain.Query;
    using System.Data;
    using System.Xml;
    using Dalyan.Entities.Models;
    using Dalyan.Entities.Enumerations;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    
    public class ProductService
    {
    	private readonly Container _container;
    	public ProductService(Container container)
    	{
    		_container = container;
    	}
    
    	    
    	public ServiceResult<Product> Add(Product obj)
    	{
    		try
    		{
    			IMediator service = _container.GetInstance<IMediator>();
    			IUserContext currentUser = _container.GetInstance<IUserContext>();
    			obj.CreatedDate = DateTime.Now;
    			obj.CreatedUserId = currentUser.CurrentUserIdentity.UserID;
    			obj.CreatedIpAddress = currentUser.CurrentUserIdentity.IpAddress;
    			obj.UpdatedDate = DateTime.Now;
    			obj.UpdatedUserId = currentUser.CurrentUserIdentity.UserID;
    			obj.UpdatedIpAddress = currentUser.CurrentUserIdentity.IpAddress;
    			obj.IsDeleted = false;
    			var query = new ProductAddQuery();
    			query.Product = obj;
    			return new ServiceResult<Product>(service.Proccess(query), message: ClientErrorMessage.Success(), state: ServiceResultStates.SUCCESS);
    		}
    		catch(ExceptionLog ex)
    		{
    			LoggerService.Logger.Log(_container, ex);
    			return new ServiceResult<Product>(result: null, message: ClientErrorMessage.Error(), state: ServiceResultStates.ERROR);
    		}
    	}
    	public ServiceResult<Product> Edit(Product obj)
    	{
    		try
    		{
    			IMediator service = _container.GetInstance<IMediator>();
    			IUserContext currentUser = _container.GetInstance<IUserContext>();
    			var query = new ProductEditQuery();
    			obj.UpdatedDate = DateTime.Now;
    			obj.UpdatedUserId = currentUser.CurrentUserIdentity.UserID;
    			obj.UpdatedIpAddress = currentUser.CurrentUserIdentity.IpAddress;
    			query.Product = obj;
    			return new ServiceResult<Product>(service.Proccess(query), message: ClientErrorMessage.Success(), state: ServiceResultStates.SUCCESS);
    		}
    		catch(ExceptionLog ex)
    		{
    			LoggerService.Logger.Log(_container, ex);
    			return new ServiceResult<Product>(result: null, message: ClientErrorMessage.Error(), state: ServiceResultStates.ERROR);
    		}
    	}
    	public ServiceResult<Product> Retrieve(int Id)
    	{
    		try
    		{
    			IMediator service = _container.GetInstance<IMediator>();
    			var query = new ProductRetrieveQuery{ Id = Id };
    			return new ServiceResult<Product>(service.Proccess(query), message: ClientErrorMessage.Success(), state: ServiceResultStates.SUCCESS);
    		}
    		catch(ExceptionLog ex)
    		{
    			LoggerService.Logger.Log(_container, ex);
    			return new ServiceResult<Product>(result: null, message: ClientErrorMessage.Error(), state: ServiceResultStates.ERROR);
    		}
    	}
    	public ServiceResult<IList<Product>> GetAll()
    	{
    		try
    		{
    			IMediator service = _container.GetInstance<IMediator>();
    			var query = new ProductGetAllQuery();
    			return new ServiceResult<IList<Product>>(service.Proccess(query), message: ClientErrorMessage.Success(), state: ServiceResultStates.SUCCESS);
    		}
    		catch(ExceptionLog ex)
    		{
    			LoggerService.Logger.Log(_container, ex);
    			return new ServiceResult<IList<Product>>(result: null, message: ClientErrorMessage.Error(), state: ServiceResultStates.ERROR);
    		}
    	}
    	public ServiceResult<string> Delete(int Id)
    	{
    		try
    		{
    			IMediator service = _container.GetInstance<IMediator>();
    			var query = new ProductDeleteQuery{ Id = Id };
    			return new ServiceResult<string>(service.Proccess(query).ToString(), message: ClientErrorMessage.Success(), state: ServiceResultStates.SUCCESS);
    		}
    		catch(ExceptionLog ex)
    		{
    			LoggerService.Logger.Log(_container, ex);
    			return new ServiceResult<string>(result: null, message: ClientErrorMessage.Error(), state: ServiceResultStates.ERROR);
    		}
    	}
    }
}
