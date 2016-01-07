﻿//------------------------------------------------------------------------------
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

    public class UserEditQuery : IQuery<Dalyan.Entities.Models.User>
    {
        public Dalyan.Entities.Models.User User { get; set; }
    }

    public class UserEditQueryHandler : IQueryHandler<UserEditQuery, Dalyan.Entities.Models.User>
    {
        private readonly DbEntities _db;
        public UserEditQueryHandler()
        {
            _db = new DbEntities();
        }


        public Dalyan.Entities.Models.User Handler(UserEditQuery query)
        {
            try
            {
                var obj = new Dalyan.Db.User();
                obj = _db.User.FirstOrDefault(x => x.Id == query.User.Id);
                obj.Id = query.User.Id;
                obj.CompanyId = query.User.CompanyId;
                obj.Name = query.User.Name;
                obj.Email = query.User.Email;
                obj.UserType = query.User.UserType;
                obj.CreatedDate = query.User.CreatedDate;
                obj.CreatedIpAddress = query.User.CreatedIpAddress;
                obj.CreatedUserId = query.User.CreatedUserId;
                obj.UpdatedDate = query.User.UpdatedDate;
                obj.UpdatedIpAddress = query.User.UpdatedIpAddress;
                obj.UpdatedUserId = query.User.UpdatedUserId;
                obj.IsDeleted = query.User.IsDeleted;
                _db.SaveChanges();
                return query.User;

            }
            catch (Exception ex)
            {
                throw new ExceptionLog(LogType.DATABASE_UPDATE, LogLevel.ERROR, ex, "EditQueryHandler");
            }
        }
    }

}
