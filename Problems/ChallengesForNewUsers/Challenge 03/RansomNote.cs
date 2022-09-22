namespace Problems.Challenge_03;

public class RansomNote
{
    /*
     * data su 2 stringa a i b i metoda treba da vrati true ako string a moze da se konstruise od stringa b, a false ukoliko ne moze
     * treba uzeti svako slovo iz stringa b i proveriti da li se nalazi u stringu a, a da pritom elementi stringa b mogu da se koriste samo 1x
     * prvo sam razmisljao da proverim koji od ta 2 stringa je duzi pa da prva for petlja bude za taj string a druga za kraci, medjutim mislim da ne treba
     * mislim da je dovoljno da se prodje samo kroz string b zato sto se od njega ispituje da li ima sve potrebne elemente za string a
     * kada se 1 element ispita, onda se prelazi na drugi
     * ali kako da znam da se jedan element stringa b nalazi u stringu a i da je u redu i ako se ne nalazi, ukoliko su ostali elementi dovoljni da formiraju string a
     * na primer, string a je "aa", a string b je "aab" i tako se element "b" iz stringa b ne nelazi u stringu a, ali su ostali njegovi elementi dovoljni da
     * kreiraju string a "aa"
     * kako onda da uzmem elemente is stringa b samo 1x a da ne bude to izbacivanjem iz neke liste a da pritom prolazim kroz tu listu
     * da li mozda moze da se napravi while petlja gde je uslov stringa.length i da se on vremenom smanjuje kako se budu pronalazili elementi
     * koji se nalaze u string b
     * magazine slova treba da se izbacuju iz liste kada se izvrsi provera jer moze da se koristi samo 1x
     */
    
    public bool CanConstruct(string ransomNote, string magazine)
    {
        List<char> ransomNoteCharList = ransomNote.ToCharArray().ToList();
        List<char> magazineCharList = magazine.ToCharArray().ToList();

        int index = 0;
        while (ransomNoteCharList.Count > 0 && index < magazine.Length)
        {
            var elementToRemove = ransomNoteCharList.Where(a => a.Equals(magazineCharList[index])).ToList();
            if (elementToRemove.Count > 0)
            {
                ransomNoteCharList.Remove(elementToRemove[0]);
            }
            index++;
        }

        return ransomNoteCharList.Count == 0;
    }

    /// <summary>
    /// Resenje sa interneta
    /// Jednostavno, elegantno, genijalno
    /// </summary>
    /// <param name="ransomNote"></param>
    /// <param name="magazine"></param>
    /// <returns></returns>
    public bool CanConstructLeetCodeSolution(string ransomNote, string magazine)
    {
        int[] englishAlphabetArray = new int[26];
        for (int i = 0; i < magazine.Length; i++)
        {
            englishAlphabetArray[magazine[i] - 'a']++;
        }

        for (int i = 0; i < ransomNote.Length; i++)
        {
            if (--englishAlphabetArray[ransomNote[i] - 'a'] < 0)
            {
                return false;
            }
        }

        return true;
    }
}