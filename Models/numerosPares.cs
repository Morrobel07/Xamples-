using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace LanguageFeatures.Models;

class NumerosPares : IEnumerable<int>
{
    private int _limite;

    public NumerosPares(int limite)
    {
        _limite = limite;
    }

    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < _limite; i++)
        {
            if (i % 2 == 0)
            {
                yield return i;
            }

        }

    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }


}