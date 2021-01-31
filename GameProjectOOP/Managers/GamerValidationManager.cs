using GameProjectOOP.Abstract;
using GameProjectOOP.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectOOP
{
    public class GamerValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id>0)
            {

                return true;
            }else
            {
        
                return false;
            }
        }
    }



}

