﻿namespace BinaryPatrick.ArgumentHelper;

public interface IArgumentParser<T> where T : class, new()
{
    IArgumentParser<T> SetHelpFlags(string fullFlag, string shortFlag);
    IArgumentParser<T> AddDescription(string text);
    IArgumentParser<T> ShowHelpText();
    T Parse(string[] arguments);

}