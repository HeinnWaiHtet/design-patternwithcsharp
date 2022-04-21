
namespace DesignPatterns.Builder.Demo
{
    public class Text
    {
        #region Properties

        public string? displayValue { get; set; }

        public string? color { get; set; }

        public string? font { get; set; }

        public string? decoration { get; set; }
        #endregion

        #region Constructor

        public Text(Builder builder)
        {
            this.displayValue = builder.GetName();
            this.color = builder.GetColor();
            this.decoration = builder.GetDecoration();
            this.font = builder.GetFont();
        }
        #endregion

        #region Methods

        public static Builder CreateBuilder => new Builder();
        #endregion
    }
}
