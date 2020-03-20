using System;

namespace APPBASE.Services
{
    public interface ICalculator
    {
        decimal? getNetAmount();
        decimal? getGrossAmount();
        decimal? getDiscRate();

    }
}
