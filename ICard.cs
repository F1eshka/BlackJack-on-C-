using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.BlackJack
{
    public interface ICard
    {
        string Suit { get; }
        string Rank { get; }
        int Value { get; }
        string ToString();
    }

}
