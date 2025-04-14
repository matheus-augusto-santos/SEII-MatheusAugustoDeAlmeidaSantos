using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Data;

namespace CalculadoraAPP;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty]    
    private string _expressionDisplay = string.Empty;

    [ObservableProperty]    
    private string _resultDisplay = string.Empty;

    [ObservableProperty]
    private int _cursorPosition;

    [RelayCommand]
    public void HandleButtonPress(string buttonText)
    {
        var curPos = _cursorPosition; 

        if (buttonText == "(  )")
        {
            buttonText = _expressionDisplay.ToCharArray().Where(x => x == '(' || x == ')')
                .Count() % 2 == 0 ? "(" : ")";
        }

        if (buttonText == "AC")
        {
            ExpressionDisplay = string.Empty;
            ResultDisplay = string.Empty;
        }
        else if (int.TryParse(buttonText, out var _) || buttonText == "%" || buttonText == ".")
        {
            var ch = buttonText[0];
            ExpressionDisplay = _expressionDisplay.Insert(_cursorPosition, ch.ToString());
            _cursorPosition = curPos + 1;

            if (!double.TryParse(ExpressionDisplay, out var _))
            {
                try
                {
                    double result = Convert.ToDouble(new DataTable().Compute(GenerateExpression(), null));
                    ResultDisplay = result.ToString();
                }
                catch
                {
                    // swallow
                }
            }
        }
        else if (buttonText == "=")
        {
            try
            {
                double result = Convert.ToDouble(new DataTable().Compute(GenerateExpression(), null));
                ResultDisplay = result.ToString();
            }
            catch
            {
                ResultDisplay = "Format error";
                return;
            }

            ExpressionDisplay = ResultDisplay;
            ResultDisplay = string.Empty;
        }
        else if (buttonText == "DEL")
        {
            if (!string.IsNullOrEmpty(ExpressionDisplay))
                ExpressionDisplay = ExpressionDisplay.Remove(ExpressionDisplay.Length - 1);
        }
        else
        {
            var ch = buttonText[0];
            ExpressionDisplay = ExpressionDisplay.Insert(_cursorPosition, ch.ToString());
            _cursorPosition = curPos + 1;
        }
    }

    private string GenerateExpression() => ExpressionDisplay.Replace('×', '*').Replace('÷', '/').Replace("%", "*0.01").Replace('(', '*').Replace(")*", "*").Replace(")", "*");
}
