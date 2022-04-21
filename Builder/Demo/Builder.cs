using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Demo
{
    public class Builder
    {
        #region Properties

        private string? displayValue { get; set; }

        private string? color { get; set; }

        private string? font { get; set; }

        private string? decoration { get; set; }
        #endregion

        #region BuilderCreateMethods

        public string GetName() => this.displayValue ?? string.Empty;

        public string GetColor() => this.color ?? string.Empty;

        public string GetFont() => this.font ?? string.Empty;

        public string GetDecoration() => this.decoration ?? string.Empty;

        public Builder CreateDisplayName(string? value)
        {
            this.displayValue = value;
            return this;
        }

        public Builder CreateDecoration(string? value)
        {
            this.decoration = value;
            return this;
        }

        public Builder CreateFont(string? value)
        {
            this.font = value;
            return this;
        }

        public Builder CreateColor(string? value)
        {
            this.color = value;
            return this;
        }

        public Text Build()
        {
            return new Text(this);
        }
        #endregion
    }
}
