using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace LsSoft.AppSupport.Module.User.Domain
{
  public class User : AggregateRoot<string>
  {

    /// <summary>
    /// 账号
    /// </summary>
    public string Account { get; set; }

    /// <summary>
    /// 密码
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    /// 电子邮件
    /// </summary>
    public string Email { get; set; }

    public User()
    {

    }

    /// <summary>
    /// 添加用户
    /// </summary>
    public void AddUser()
    {

    }

  }
}
