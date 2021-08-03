using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.Interface_Segregation_Principle
{
    public interface ICar
    {
        void Drive();
    }
    public interface IAirplane
    {
        void Fly();
    }
}
