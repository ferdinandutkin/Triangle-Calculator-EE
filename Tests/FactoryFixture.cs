using System;
using Triangles;

namespace Tests
{
    public class FactoryFixture : IDisposable
    {
        public LegoShapeFactory Factory;
        public FactoryFixture()
        {
            Factory = new LegoShapeFactory();

        }

        public void Dispose()
        {
        }
    }
}