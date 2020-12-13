using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Сводное описание для LoginResponseModel
/// </summary>
[DataContract]
public class LoginResponseModel
{
    [DataMember(Name = "status")]
    public int Status { get; set; }

    [DataMember(Name = "message")]
    public string Message { get; set; }
}