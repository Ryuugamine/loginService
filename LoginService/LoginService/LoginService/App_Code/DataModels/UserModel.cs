using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Сводное описание для User
/// </summary>
[DataContract]
public class UserModel
{
    [DataMember(Name = "id")]
    public int Id { get; set; }

    [DataMember(Name = "login")]
    public string Login { get; set; }

    [DataMember(Name = "password")]
    public string Password { get; set; }
}