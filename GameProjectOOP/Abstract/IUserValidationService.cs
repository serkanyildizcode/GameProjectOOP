using GameProjectOOP.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectOOP.Abstract
{
   public interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
