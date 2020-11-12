using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Sg.Enums;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Models.User;

namespace KeyPayV2.Sg.Functions
{
    public class UserFunction : BaseFunction
    {
        public UserFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get User Details
        /// </summary>
        /// <remarks>
        /// Gets details about the user.
        /// </remarks>
        public UserModel GetUserDetails()
        {
            return ApiRequest<UserModel>($"/user");
        }

        /// <summary>
        /// Create New User
        /// </summary>
        /// <remarks>
        /// Creates a new user.
        /// </remarks>
        public NewUserCreatedModel CreateNewUser(NewUserModel model)
        {
            return ApiRequest<NewUserCreatedModel,NewUserModel>($"/user", model, Method.POST);
        }
    }
}
