﻿/*
 * IOFile Interface
 */

namespace SortedNumbersAPI.Scripts
{
    public interface IIOFile
    {
        public string ReadFromFile();

        public void SaveResult(string value);

        public string CorrectInput(string val);
        
    }
}
