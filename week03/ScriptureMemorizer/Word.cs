using System.Text;
public class Word
{
    private string _text;
    private bool _isHidden;

    public Word()
    {
        _text = "";
        _isHidden = false;
    }

    public void SetWord(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool isHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        string hiddenWord = "";
        if (_isHidden == false)
        {
            return _text;
        }

        else /*(_isHidden == true)*/
        {
            StringBuilder sb = new StringBuilder();
            foreach (char letter in _text)
            {
                if (char.IsLetter(letter))
                {
                    hiddenWord += '_';
                }
                else
                {
                    hiddenWord += letter;
                }
            }
            return hiddenWord;
        }

    }
}