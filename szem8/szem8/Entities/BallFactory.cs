﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using szem8.Abstractions;

namespace szem8.Entities
{
    public class BallFactory : IToyFactory
    {
        public Ball CreateNew()
        {
            return new Ball();
        }

        Toy IToyFactory.CreateNew()
        {
            throw new NotImplementedException();
        }
    }
}
