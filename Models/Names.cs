using System.Collections;
using System.Collections.Generic;

namespace LanguageFeatures.Models;

public class Nombres : IEnumerable<string>
{
    private string[] _nombres;
    public Nombres(string[] nombres)
    {
        _nombres = nombres;
    }

    public IEnumerator<string> GetEnumerator()
    {
        foreach (string nombre in _nombres)
        {
            yield return nombre;

        }

    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}