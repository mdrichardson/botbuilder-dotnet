﻿// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bot.Schema
{
    /// <summary>
    /// Names for signin invoke operations in the token protocol
    /// </summary>
    public static class SignInOperations
    {
        /// <summary>
        /// Name for the signin invoke to verify the 6-digit authentication code as part of sign-in
        /// </summary>
        /// <remarks>
        /// This invoke operation includes a value containing a state property for the magic code
        /// </remarks>
        public const string VerifyStateOperationName = "signin/verifyState";

        /// <summary>
        /// Name for signin invoke to perform a token exchange
        /// </summary>
        /// <remarks>
        /// This invoke operation includes a value of the token exchange class
        /// </remarks>
        public const string TokenExchangeOperationName = "signin/tokenExchange";
    }
}
