using EmployeeManagement.Dtos.UserLogin;
using EmployeeManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Linq.Dynamic.Core;
using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Utilities;
using EmployeeManagement.Infrastructure.Repositories;
using EmployeeManagement.Models.UserLogin;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeManagement.DataLayers.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _dataContext;

        public UserRepository(DataContext dataContext, IServiceProvider serviceProvider)
        {
            //  _dataContext = dataContext;
            _dataContext = serviceProvider.CreateScope().ServiceProvider.GetRequiredService<DataContext>();
        }

        public async Task AddAsync(User entity)
        {
            await _dataContext.User.AddAsync(entity);
            await _dataContext.SaveChangesAsync();
        }

        public async Task AddAsync1(User entity)
        {
            await _dataContext.User.AddAsync(entity);
            await _dataContext.SaveChangesAsync();

        }
        public async Task AddUser(User entity)
        {
            await _dataContext.User.AddAsync(entity);
            await _dataContext.SaveChangesAsync();

        }
        public int GetLastNextDoorUserId(string Email)
        {
           
            var obj = _dataContext.User.Where(x => x.Email == Email).FirstOrDefault();
            return obj.Id;
        }

        public async Task LoginAddAsync(LoginModule entity)
        {
            var obj = _dataContext.User.Where(x => x.Id == entity.UserId).FirstOrDefault();
            if (obj != null)
            {
                obj.LastLogin = DateTime.Now;
                _dataContext.User.Update(obj);
            }
            await _dataContext.LoginModule.AddAsync(entity);
            await _dataContext.SaveChangesAsync();


        }

        public void Edit(User entity)
        {
            _dataContext.User.Update(entity);
             _dataContext.SaveChanges();
        }

        public async Task<User> GetAsync(int id, int header)
        {
            return await _dataContext.User.FindAsync(id);
        }
        public async Task<User> GetNextDoorUserAsync(int userid)
        {
            var data = _dataContext.User.Where(x => x.Id == userid).FirstOrDefault();
            return data;
         
        }

        public async Task<UserDetailDto> GetDetailAsync(int id, int header)
        {
            return await (from s in _dataContext.User
                          where s.Id == id && s.CompanyId == header  //&& s.Status == Constants.RecordStatus.Active
                          select new UserDetailDto
                          {
                              Id = s.Id,
                              UserFirstName = s.UserFirstName,
                              UserLastName = s.UserLastName,
                              UserName = s.UserName,
                              Password = s.Password,
                              Mobile = s.Mobile,
                              Email = s.Email,
                              RoleId = s.RoleId,
                              RoleName = s.Role.RoleName,
                              CompanyId = s.CompanyId,
                              Ip_Address = s.IpAddress,
                              Finance_year = s.FinanceYear,
                              App_id = s.AppId,
                              CompanyName = s.Company.CompanyName,
                              image = s.image,
                              Status=s.Status,
                              LangId = s.LangId
                              

                          })
                          .AsNoTracking()
                          .SingleOrDefaultAsync();
        }

        public async Task<JqDataTableResponse<UserDetailDto>> GetPagedResultAsync(JqDataTableRequest model, int header)
        {
            if (model.Length == 0)
            {
                model.Length = Constants.DefaultPageSize;
            }

            var filterKey = model.Search.Value;

            var linqStmt = (from s in _dataContext.User
                            where s.Status != Constants.RecordStatus.Deleted && (model.filterKey == null || EF.Functions.Like(s.UserFirstName, "%" + model.filterKey + "%")
                            || EF.Functions.Like(s.UserFirstName, "%" + model.filterKey + "%")) && s.CompanyId == header
                            select new UserDetailDto
                            {
                                Id = s.Id,
                                UserFirstName = s.UserFirstName,
                                UserLastName = s.UserLastName,
                                UserName = s.UserName,
                                Password = s.Password,
                                Mobile = s.Mobile,
                                Email = s.Email,
                                RoleId = s.RoleId,
                                RoleName = s.Role.RoleName,
                                App_id = s.AppId,
                                Finance_year = s.FinanceYear,
                                Ip_Address = s.IpAddress,
                                image = s.image,
                                CompanyId = s.CompanyId,
                                Status=s.Status,
                                LangId = s.LangId,
                            })
                            .AsNoTracking();

            var sortExpresstion = model.GetSortExpression();

            var pagedResult = new JqDataTableResponse<UserDetailDto>
            {
                RecordsTotal = await _dataContext.User.CountAsync(x => x.Status != Constants.RecordStatus.Deleted),
                RecordsFiltered = await linqStmt.CountAsync(),
                Data = await linqStmt.OrderBy(sortExpresstion).Skip(model.Start).Take(model.Length).ToListAsync()
            };
            return pagedResult;
        }

        public async Task DeleteAsync(int id, int header)
        {
            var data = await _dataContext.User.FindAsync(id);
            data.Status = Constants.RecordStatus.Deleted;
            _dataContext.User.Update(data);
            await _dataContext.SaveChangesAsync();
        }

        public bool GetByUserAllradyAsync(int userid)
        {
            var user = _dataContext.LoginModule.Where(x => x.UserId == userid && x.Status == Constants.RecordStatus.Created).FirstOrDefault();

            if (user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

     
        public async Task<UserDetailDto> GetByUserAsync(string username)
        {
            return await (from s in _dataContext.User
                          where s.UserName == username
                          select new UserDetailDto
                          {
                              Id = s.Id,
                              UserFirstName = s.UserFirstName,
                              UserLastName = s.UserLastName,
                              UserName = s.UserName,
                              Password = s.Password,
                              Mobile = s.Mobile,
                              Email = s.Email,
                            
                              RoleId = s.RoleId,
                              RoleName = s.Role.RoleName,
                              App_id = s.AppId,
                              Finance_year = s.FinanceYear,
                              Ip_Address = s.IpAddress,
                              CompanyId = s.CompanyId,
                              Status=s.Status,
                              otp = s.otp,
                              LangId = s.LangId,
                             

                          })
                         .AsNoTracking()
                         .SingleOrDefaultAsync();
        }
        public async Task<UserDetailDto> GetBynxtUserAsync(int userid)
        {
            return await (from s in _dataContext.User
                          where s.Id == userid
                          select new UserDetailDto
                          {
                              Id = s.Id,
                              UserFirstName = s.UserFirstName,
                              UserLastName = s.UserLastName,
                              UserName = s.UserName,
                              Password = s.Password,
                              Mobile = s.Mobile,
                              Email = s.Email,
                              RoleId = s.RoleId,
                              RoleName = s.Role.RoleName,
                              App_id = s.AppId,
                              Finance_year = s.FinanceYear,
                              Ip_Address = s.IpAddress,
                              CompanyId = s.CompanyId,
                              Status = s.Status,
                              otp = s.otp,
                              LangId = s.LangId,


                          })
                         .AsNoTracking()
                         .SingleOrDefaultAsync();
        }
        public async Task<UserDetailDto> getOtp(string email)
        {
            return await (from s in _dataContext.User
                          where s.Email == email
                          select new UserDetailDto
                          {
                              Id = s.Id,
                              UserFirstName = s.UserFirstName,
                              UserLastName = s.UserLastName,
                              UserName = s.UserName,
                              Password = s.Password,
                              Mobile = s.Mobile,
                              Email = s.Email,
                              RoleId = s.RoleId,
                              RoleName = s.Role.RoleName,
                              App_id = s.AppId,
                              Finance_year = s.FinanceYear,
                              Ip_Address = s.IpAddress,
                              CompanyId = s.CompanyId,
                              otp = s.otp

                          })
                         .AsNoTracking()
                         .SingleOrDefaultAsync();
        }

        public async Task<UserDetailDto> Login(UserLoginModel model)
        {

            var user = await (from s in _dataContext.User
                              where s.UserName == model.UserName && s.Password == Utility.Encrypt(model.Password) && s.Status== Constants.RecordStatus.Active
                              select new UserDetailDto
                              {
                                  Id = s.Id,
                                  UserFirstName = s.UserFirstName,
                                  UserLastName = s.UserLastName,
                                  UserName = s.UserName,
                                  Password = s.Password,
                                  Mobile = s.Mobile,
                                  Email = s.Email,
                                  RoleId = s.RoleId,
                                  RoleName = s.Role.RoleName
                                  
                              })
                         .AsNoTracking()
                         .SingleOrDefaultAsync();
            if (user != null)
            {
                var obj = _dataContext.User.Where(x => x.Id == user.Id).FirstOrDefault();
                obj.LastLogin = DateTime.Now;
                _dataContext.User.Update(obj);
            }
            return user;
        }
        public async Task<List<UserDetailDto>> GetAllAsync(int header)
        {
            return await (from s in _dataContext.User
                          where s.CompanyId == header
                          select new UserDetailDto
                          {
                              Id = s.Id,
                              UserFirstName = s.UserFirstName,
                              UserLastName = s.UserLastName,
                              UserName = s.UserName,
                              Password = s.Password,
                              Mobile = s.Mobile,
                              Email = s.Email,
                              RoleId = s.RoleId,
                              RoleName = s.Role.RoleName,
                              App_id = s.AppId,
                              Finance_year = s.FinanceYear,
                              Ip_Address = s.IpAddress,
                              image = s.image,
                              CompanyId = s.CompanyId,
                              Status=s.Status,
                              LangId = s.LangId
                          })
                          .AsNoTracking()
                          .ToListAsync();
        }
        public async Task<UserDetailDto> isExist(string email)
        {
            return await (from s in _dataContext.User
                          where s.Email == email
                          select new UserDetailDto
                          {
                              Id = s.Id,
                              UserFirstName = s.UserFirstName,
                              UserLastName = s.UserLastName,
                              UserName = s.UserName,
                              Password = s.Password,
                              Mobile = s.Mobile,
                              Email = s.Email,
                              RoleId = s.RoleId,
                              RoleName = s.Role.RoleName,
                              CompanyId = s.CompanyId

                          })
                         .AsNoTracking()
                         .SingleOrDefaultAsync();
        }

        

        public async Task LogOut(int id, int header)
        {
            var data = await _dataContext.LoginModule.Where(x => x.UserId == id && x.CompanyId==header && x.LastLogin == null).FirstOrDefaultAsync();
            data.LastLogin = DateTime.Now;
            data.Status1 = false;
            data.Status = Constants.RecordStatus.Deleted;
            _dataContext.LoginModule.Update(data);
            await _dataContext.SaveChangesAsync();


        }

        public async Task saveOtp(string email, int otp)
        {
            var data = await _dataContext.User.Where(x => x.Email == email).FirstOrDefaultAsync();
            data.otp = otp;

            _dataContext.User.Update(data);
            await _dataContext.SaveChangesAsync();

        }

        public async Task changePassword(string email, string password)
        {
            var data = await _dataContext.User.Where(x => x.Email == email).FirstOrDefaultAsync();
            data.Password = Utility.Encrypt(password);

            _dataContext.User.Update(data);
            await _dataContext.SaveChangesAsync();

        }

        public async Task NxtchangePassword(int userid, string Newpassword)
        {
            try
            {


                var data = await _dataContext.User.Where(x => x.Id == userid).FirstOrDefaultAsync();
                data.Password = Utility.Encrypt(Newpassword);

                _dataContext.User.Update(data);
                await _dataContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //with online status
        public async Task<JqDataTableResponse<UserDetailDto>> OnlineUserPagedResult(JqDataTableRequest model, int header)
        {
            if (model.Length == 0)
            {
                model.Length = Constants.DefaultPageSize;
            }

            var filterKey = model.Search.Value;

            var linqStmt = (from s in _dataContext.User
                            join l in _dataContext.LoginModule on s.Id equals l.UserId
                            where s.Status != Constants.RecordStatus.Deleted && (model.filterKey == null || EF.Functions.Like(s.UserFirstName, "%" + model.filterKey + "%")
                            || EF.Functions.Like(s.UserLastName, "%" + model.filterKey + "%")) && s.CompanyId == header
                            select new UserDetailDto
                            {
                                Id = s.Id,
                                UserFirstName = s.UserFirstName,
                                UserLastName = s.UserLastName,
                                UserName = s.UserName,
                                Password = s.Password,
                                Mobile = s.Mobile,
                                Email = s.Email,
                                RoleId = s.RoleId,
                                RoleName = s.Role.RoleName,
                                CallStatus = l.Status1 ?? false,
                                CompanyId =s.CompanyId,
                                LangId  = s.LangId

                            })
                            .AsNoTracking();

            var sortExpresstion = model.GetSortExpression();

            var pagedResult = new JqDataTableResponse<UserDetailDto>
            {
                RecordsTotal = await _dataContext.User.CountAsync(x => x.Status != Constants.RecordStatus.Deleted),
                RecordsFiltered = await linqStmt.CountAsync(),
                Data = await linqStmt.OrderBy(sortExpresstion).Skip(model.Start).Take(model.Length).ToListAsync()
            };
            return pagedResult;
        }

        public bool CheckPasswordAsync(int adminid, string adminPassword)
        {
           
            var pass = adminPassword;
            var user = _dataContext.User.Where(x => x.Id == adminid && (Utilities.Utility.Decrypt(pass, x.Password))).FirstOrDefault();

            if (user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task ChangePasswordAdmin(ChangePasswordModel model) /*changePasswordByAdmin*/
        {
            var data = await _dataContext.User.Where(x => x.Id == model.id).FirstOrDefaultAsync();
            data.Password = Utility.Encrypt(model.NewPassword);

            _dataContext.User.Update(data);
            await _dataContext.SaveChangesAsync();

        }

        public async Task<UserDetailDto> GetByUserEmailAsync(string Email)
        {
            return await (from s in _dataContext.User
                          where s.Email == Email
                          select new UserDetailDto
                          {
                              Id = s.Id,
                              UserFirstName = s.UserFirstName,
                              UserLastName = s.UserLastName,
                              UserName = s.UserName,
                              Password = s.Password,
                              Mobile = s.Mobile,
                              Email = s.Email,
                              RoleId = s.RoleId,
                              RoleName = s.Role.RoleName,
                              App_id = s.AppId,
                              Finance_year = s.FinanceYear,
                              Ip_Address = s.IpAddress,
                              CompanyId = s.CompanyId,
                              LangId =s.LangId
                          })
                         .AsNoTracking()
                         .SingleOrDefaultAsync();
        }

    }
}
