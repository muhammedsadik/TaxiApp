using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiApp.Core.Entities;

namespace TaxiApp.Core.Entities
{

  public class User : IEntity
  {
    public Guid Id { get; set; }
    public string UserName { get; set; }
    public string NormalizedUserName { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string NormalizedEmail { get; set; }
    public string EmailConfirmValue { get; set; }
    public bool EmailConfirmed { get; set; }
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
    public string PhoneNumber { get; set; }
    public string PhoneNumberConfirmed { get; set; }
    public bool IsActive { get; set; }
    public int AccessFailedCount { get; set; }
    public DateTime LastPasswordChangeTime { get; set; }
    public DateTime CreationTime { get; set; }
    public Guid? CreatorId { get; set; }
    public DateTime LastModificationTime { get; set; }
    public Guid? LastModifierId { get; set; }
    public bool IsDelated { get; set; }
    public Guid? DelaterId { get; set; }
    public DateTime DelationTime { get; set; }

    public User()
    {

    }

    public User(string userName, string surname, string email, string phoneNumber)
    {
      //ne yapacağını planla örn: validation(username not null gibi) veya user hangi parametrelri alsın ve nasıl ayarlamalar yapılsın.
    }

  }
}
