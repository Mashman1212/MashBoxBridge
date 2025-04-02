using System;

namespace MashBoxBridge.Common.Interfaces
{
    [Serializable]
    public enum DataStyle
    {
        Slider,
        Button,
        Selector
    }
    
    public interface ISmartDataBase
    {
        string ID { get; }
        bool Initialized { get; }
        
        DataStyle Style { get; }
        void OnChanged();
        string GetValueText();
        void SaveData();
        void LoadData();
        void ResetData();
        string GetDataLabel();
        string GetDataDescription();
        void DataSubmitted();

        float GetNormalizedValue();

        event Action OnChangedEvent;
    }

    public interface ISmartData<T> : ISmartDataBase
    {
        T Value { get; set; }
    }
}