﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiApp.Domain.Entities.Users;
using TaxiApp.EntityFrameworkCore.Concrete.Context;
using TaxiApp.EntityFrameworkCore.Concrete.GenericRepository;

namespace TaxiApp.EntityFrameworkCore.Concrete.EntityRepository.Users
{
  public class UserRepository : Repository<User, TaxiAppDbContext>, IUserRepositoy
  {
  }
}