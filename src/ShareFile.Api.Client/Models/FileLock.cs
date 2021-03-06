// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//	   Copyright (c) 2018 Citrix ShareFile. All rights reserved.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Net;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShareFile.Api.Client.Extensions;
using ShareFile.Api.Client.Exceptions;

namespace ShareFile.Api.Client.Models 
{
#if !ShareFile
	/// <summary>
	/// FileLock
	/// </summary>
	public class FileLock : ODataObject 
	{
		/// <summary>
		/// Lock Id
		/// </summary>
		public string LockId { get; set; }
		/// <summary>
		/// User who owns the Lock
		/// </summary>
		public Principal Owner { get; set; }
		/// <summary>
		/// Expiration time in minutes.
		/// </summary>
		public int? ExpirationTimeInMinutes { get; set; }
		/// <summary>
		/// Expiration date. Takes precedence over ExpirationTimeInMinutes if both are provided
		/// </summary>
		public DateTime? ExpirationDate { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as FileLock;
			if(typedSource != null)
			{
				LockId = typedSource.LockId;
				Owner = typedSource.Owner;
				ExpirationTimeInMinutes = typedSource.ExpirationTimeInMinutes;
				ExpirationDate = typedSource.ExpirationDate;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("LockId", out token) && token.Type != JTokenType.Null)
				{
					LockId = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Owner", out token) && token.Type != JTokenType.Null)
				{
					Owner = (Principal)serializer.Deserialize(token.CreateReader(), typeof(Principal));
				}
				if(source.TryGetProperty("ExpirationTimeInMinutes", out token) && token.Type != JTokenType.Null)
				{
					ExpirationTimeInMinutes = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("ExpirationDate", out token) && token.Type != JTokenType.Null)
				{
					ExpirationDate = (DateTime?)serializer.Deserialize(token.CreateReader(), typeof(DateTime?));
				}
			}
		}
	}
#endif
}