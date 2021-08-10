using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace LsSoft.AppSupport.Module.Tenant.Domain
{
  /// <summary>
  /// 租户聚合根
  /// </summary>
  public class Tenant: AggregateRoot<string>
  {
    /// <summary>
    /// 编号
    /// </summary>
    public string Number { get; set; }

    /// <summary>
    /// 描述信息
    /// </summary>
    public string Description { get; set; }

    public Tenant()
    {

    }
    public void AddTenant()
    {

    }

  }
}
