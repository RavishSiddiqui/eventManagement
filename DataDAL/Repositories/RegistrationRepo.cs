using Dapper;
using DataDAL.Repositories;
using DataDOM;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace Event.DAL.Repositories
{
    public class RegistrationRepo : BaseRepository, IRegistrationRepo
    {
        public RegistrationRepo(IConfiguration configuration) : base(configuration) { }
        public string NEW_Admin(Registration registration)
        {
            try
            {
                int rows_affected = CreateUser(registration);
                return rows_affected > 0 ? "Success" : "Fail";
            }
            catch (Exception)
            {
                return "Fail";
                throw;
            }
        }
        public string NEW_Customer(Registration registration)
        {
            try
            {
                int rows_affected = CreateUser(registration);
                return rows_affected > 0 ? "Success" : "Fail";
            }
            catch (Exception)
            {
                return "Fail";
                throw;
            }
        }
        private int CreateUser(Registration model)
        {
            int rowAffected = 0;
            #region Commented for Not in Use
            using (var connection = CreateConnection())
            {

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@UserName", model.Username);
                parameters.Add("@Address", model.Address);
                parameters.Add("@Email", model.EmailID);
                parameters.Add("@Password ", model.Password);
                parameters.Add("@ConfirmPassword", model.ConfirmPassword);

                parameters.Add("@Code", dbType:DbType.Int32, direction: ParameterDirection.Output);
                parameters.Add("@Message", model.Message, direction: ParameterDirection.Output);

                rowAffected = connection.Execute(DBConstant.RegisterUser, parameters, commandType: CommandType.StoredProcedure);

                Int32 Code = parameters.Get<Int32>("@Code");
                string Message = parameters.Get<string>("@Message");
            }
            #endregion            
            return rowAffected;
        }
    }
}