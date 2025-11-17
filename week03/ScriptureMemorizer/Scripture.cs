using System.Text;
using System.Linq;
public class Scripture
{
    private Reference _reference = new Reference();
    private List<Word> _words;
    private string _tempScripture;
    private Random _rand = new Random();
    private bool completelyHidden = false;
    //variables needed for hiding random words
    private List<int> indexToHide;
    private List<int> shuffledIndex;
    private int randomIndex = 0;

    public void SetScripture(Reference Reference, string text)
    {
        _words = new List<Word>();
        _reference = Reference;
        _tempScripture = text;

        string[] tempList = _tempScripture.Split(' ');

        foreach (string str in tempList)
        {
            Word newWord = new Word();
            newWord.SetWord(str);

            _words.Add(newWord);
        }

        //Create the index list to randomize the hidden words
        indexToHide = Enumerable.Range(0, _words.Count).ToList();
        shuffledIndex = indexToHide.OrderBy(i => _rand.Next()).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        if (randomIndex >= shuffledIndex.Count)
        {
            completelyHidden = true;
        }
        else
        {
            for (int j = 0; j < numberToHide; j++)
            {
                if (randomIndex >= shuffledIndex.Count)
                {
                    break;
                }
                int index = shuffledIndex[randomIndex];
                _words[index].Hide();
                randomIndex++;
            }
        }
    }

    public string GetDisplayText()
    {
        //string scripture = string.Join(" ", _words);
        string reference = _reference.GetDisplayText();

        StringBuilder sb = new StringBuilder();

        foreach (Word word in _words)
        {
            if (sb.Length > 0)
            {
                sb.Append(" ");
            }
            sb.Append(word.GetDisplayText());
        }
        string scripture = sb.ToString();
        return $"{reference} - {scripture}";
    }

    public bool IsCompletelyHidden()
    {
        return completelyHidden;
    }
}