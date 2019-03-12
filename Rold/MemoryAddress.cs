using System;

namespace Rold
{
    public class MemoryAddress
    {
        private IntPtr fullAddress;

        private VAMemory vaMemory;

        public MemoryAddress(int fullAddress)
        {
            this.fullAddress = (IntPtr) fullAddress;

            vaMemory = new VAMemory(Constants.application);
        }

        public MemoryAddress(int baseAddress, int offsetAddress)
        {
            fullAddress = (IntPtr) (baseAddress + offsetAddress);

            vaMemory = new VAMemory(Constants.application);
        }

        public int getValue()
        {
            return vaMemory.ReadInt32(fullAddress);
        }

        public void setValue(int value)
        {
            vaMemory.WriteInt32(fullAddress, value);
        }
    }
}