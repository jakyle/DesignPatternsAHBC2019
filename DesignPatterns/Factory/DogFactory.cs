using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class DogFactory : IFactory<IDog, DogType>
    {
        public IDog Create(DogType type)
        {
            switch (type)
            {
                case DogType.Poodle: return new Poodle();

                case DogType.GoldenRetiever: return new GoldenRetriever();

                case DogType.Pitbull: return new Pitbull();

                case DogType.Dalmation: return new Dalmation();

                default: throw new ArgumentOutOfRangeException("Invalid dog entry");
            }
        }
    }
}
