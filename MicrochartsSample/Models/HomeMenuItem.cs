using System;
using System.Collections.Generic;
using System.Text;

namespace MicrochartsSample.Models
{
    public enum MenuItemType
    {
        About,
        BarChart,
        PointChart,
        LineChart,
        DonutChart,
        CustDonutChart,
        RadialGaugeChart,
        RadarChart
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
