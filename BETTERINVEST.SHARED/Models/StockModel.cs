using AutoMapper;
using Heroic.AutoMapper;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BETTERINVEST.SHARED.Models
{
    public class StockModel : INotifyPropertyChanged, IMapFrom<Stock>, IHaveCustomMappings
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property.  
        // The CallerMemberName attribute that is applied to the optional propertyName  
        // parameter causes the property name of the caller to be substituted as an argument.  
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public int ID { get; set; }
        public string Symbol { get; set; }
        private decimal _shares;
        public decimal Shares
        {
            get { return _shares; }
            set
            {
                if (_shares != value)
                {
                    _shares = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private decimal _totalCost;
        public decimal TotalCost
        {
            get { return _totalCost; }
            set
            {
                if (_totalCost != value)
                {
                    _totalCost = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public decimal Dividend { get; set; }
        public int Frequency { get; set; }
        public bool Month01 { get; set; }
        public bool Month02 { get; set; }
        public bool Month03 { get; set; }
        public bool Month04 { get; set; }
        public bool Month05 { get; set; }
        public bool Month06 { get; set; }
        public bool Month07 { get; set; }
        public bool Month08 { get; set; }
        public bool Month09 { get; set; }
        public bool Month10 { get; set; }
        public bool Month11 { get; set; }
        public bool Month12 { get; set; }

        // Calculated Properties
        public decimal AvgCostPerShare 
        {
            get { return _totalCost / _shares; }
        }

        // Custom Automapper Mappings
        public void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.ValidateInlineMaps = false;
            configuration.CreateMap<Stock, StockModel>()
                .ForMember(s => s._shares, opt => opt.Ignore())
                .ForMember(s => s._totalCost, opt => opt.Ignore())
                .ForMember(s => s.AvgCostPerShare, opt => opt.Ignore());
        }
    }
}
