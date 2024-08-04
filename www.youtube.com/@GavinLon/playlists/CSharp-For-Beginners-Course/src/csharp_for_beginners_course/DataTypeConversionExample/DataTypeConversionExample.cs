namespace DataTypeConversionExample
{
  class DataTypeConversionExample
  {
    static void Main(string[] arguments)
    {
        short _sampleShortLiteral = byte.MinValue;
        System.Console.WriteLine($"{Environment.NewLine}Value of identifier '_sampleShortLiteral' is '{_sampleShortLiteral}'");        
        //byte _sampleByteLiteral = short.MinValue;
        byte _sampleByteLiteral = System.Convert.ToByte(short.MinValue);
        System.Console.WriteLine($"{Environment.NewLine}Value of identifier '_sampleByteLiteral' is '{_sampleByteLiteral}'");
      return;
    }
  }
}