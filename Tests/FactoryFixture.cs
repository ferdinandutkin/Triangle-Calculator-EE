using System;
using Triangles.Factories;

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