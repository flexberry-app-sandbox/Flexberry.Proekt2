﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Proekt
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Календарь.
    /// </summary>
    // *** Start programmer edit section *** (Календарь CustomAttributes)

    // *** End programmer edit section *** (Календарь CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class Календарь : ICSSoft.STORMNET.DataObject
    {
        
        private string fНачало;
        
        private int fТрудозатраты;
        
        private string fКонец;
        
        private IIS.Proekt.Планирование fПланирование;
        
        private IIS.Proekt.ПроектИС fПроектИС;
        
        private IIS.Proekt.Участник fУчастник;
        
        private IIS.Proekt.Роли fРоли;
        
        // *** Start programmer edit section *** (Календарь CustomMembers)

        // *** End programmer edit section *** (Календарь CustomMembers)

        
        /// <summary>
        /// Конец.
        /// </summary>
        // *** Start programmer edit section *** (Календарь.Конец CustomAttributes)

        // *** End programmer edit section *** (Календарь.Конец CustomAttributes)
        [StrLen(255)]
        public virtual string Конец
        {
            get
            {
                // *** Start programmer edit section *** (Календарь.Конец Get start)

                // *** End programmer edit section *** (Календарь.Конец Get start)
                string result = this.fКонец;
                // *** Start programmer edit section *** (Календарь.Конец Get end)

                // *** End programmer edit section *** (Календарь.Конец Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Календарь.Конец Set start)

                // *** End programmer edit section *** (Календарь.Конец Set start)
                this.fКонец = value;
                // *** Start programmer edit section *** (Календарь.Конец Set end)

                // *** End programmer edit section *** (Календарь.Конец Set end)
            }
        }
        
        /// <summary>
        /// Начало.
        /// </summary>
        // *** Start programmer edit section *** (Календарь.Начало CustomAttributes)

        // *** End programmer edit section *** (Календарь.Начало CustomAttributes)
        [StrLen(255)]
        public virtual string Начало
        {
            get
            {
                // *** Start programmer edit section *** (Календарь.Начало Get start)

                // *** End programmer edit section *** (Календарь.Начало Get start)
                string result = this.fНачало;
                // *** Start programmer edit section *** (Календарь.Начало Get end)

                // *** End programmer edit section *** (Календарь.Начало Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Календарь.Начало Set start)

                // *** End programmer edit section *** (Календарь.Начало Set start)
                this.fНачало = value;
                // *** Start programmer edit section *** (Календарь.Начало Set end)

                // *** End programmer edit section *** (Календарь.Начало Set end)
            }
        }
        
        /// <summary>
        /// Трудозатраты.
        /// </summary>
        // *** Start programmer edit section *** (Календарь.Трудозатраты CustomAttributes)

        // *** End programmer edit section *** (Календарь.Трудозатраты CustomAttributes)
        public virtual int Трудозатраты
        {
            get
            {
                // *** Start programmer edit section *** (Календарь.Трудозатраты Get start)

                // *** End programmer edit section *** (Календарь.Трудозатраты Get start)
                int result = this.fТрудозатраты;
                // *** Start programmer edit section *** (Календарь.Трудозатраты Get end)

                // *** End programmer edit section *** (Календарь.Трудозатраты Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Календарь.Трудозатраты Set start)

                // *** End programmer edit section *** (Календарь.Трудозатраты Set start)
                this.fТрудозатраты = value;
                // *** Start programmer edit section *** (Календарь.Трудозатраты Set end)

                // *** End programmer edit section *** (Календарь.Трудозатраты Set end)
            }
        }
        
        /// <summary>
        /// Календарь.
        /// </summary>
        // *** Start programmer edit section *** (Календарь.Планирование CustomAttributes)

        // *** End programmer edit section *** (Календарь.Планирование CustomAttributes)
        [PropertyStorage(new string[] {
                "Планирование"})]
        [NotNull()]
        public virtual IIS.Proekt.Планирование Планирование
        {
            get
            {
                // *** Start programmer edit section *** (Календарь.Планирование Get start)

                // *** End programmer edit section *** (Календарь.Планирование Get start)
                IIS.Proekt.Планирование result = this.fПланирование;
                // *** Start programmer edit section *** (Календарь.Планирование Get end)

                // *** End programmer edit section *** (Календарь.Планирование Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Календарь.Планирование Set start)

                // *** End programmer edit section *** (Календарь.Планирование Set start)
                this.fПланирование = value;
                // *** Start programmer edit section *** (Календарь.Планирование Set end)

                // *** End programmer edit section *** (Календарь.Планирование Set end)
            }
        }
        
        /// <summary>
        /// Календарь.
        /// </summary>
        // *** Start programmer edit section *** (Календарь.ПроектИС CustomAttributes)

        // *** End programmer edit section *** (Календарь.ПроектИС CustomAttributes)
        [PropertyStorage(new string[] {
                "ПроектИС"})]
        [NotNull()]
        public virtual IIS.Proekt.ПроектИС ПроектИС
        {
            get
            {
                // *** Start programmer edit section *** (Календарь.ПроектИС Get start)

                // *** End programmer edit section *** (Календарь.ПроектИС Get start)
                IIS.Proekt.ПроектИС result = this.fПроектИС;
                // *** Start programmer edit section *** (Календарь.ПроектИС Get end)

                // *** End programmer edit section *** (Календарь.ПроектИС Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Календарь.ПроектИС Set start)

                // *** End programmer edit section *** (Календарь.ПроектИС Set start)
                this.fПроектИС = value;
                // *** Start programmer edit section *** (Календарь.ПроектИС Set end)

                // *** End programmer edit section *** (Календарь.ПроектИС Set end)
            }
        }
        
        /// <summary>
        /// Календарь.
        /// </summary>
        // *** Start programmer edit section *** (Календарь.Роли CustomAttributes)

        // *** End programmer edit section *** (Календарь.Роли CustomAttributes)
        [PropertyStorage(new string[] {
                "Роли"})]
        [NotNull()]
        public virtual IIS.Proekt.Роли Роли
        {
            get
            {
                // *** Start programmer edit section *** (Календарь.Роли Get start)

                // *** End programmer edit section *** (Календарь.Роли Get start)
                IIS.Proekt.Роли result = this.fРоли;
                // *** Start programmer edit section *** (Календарь.Роли Get end)

                // *** End programmer edit section *** (Календарь.Роли Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Календарь.Роли Set start)

                // *** End programmer edit section *** (Календарь.Роли Set start)
                this.fРоли = value;
                // *** Start programmer edit section *** (Календарь.Роли Set end)

                // *** End programmer edit section *** (Календарь.Роли Set end)
            }
        }
        
        /// <summary>
        /// Календарь.
        /// </summary>
        // *** Start programmer edit section *** (Календарь.Участник CustomAttributes)

        // *** End programmer edit section *** (Календарь.Участник CustomAttributes)
        [PropertyStorage(new string[] {
                "Участник"})]
        [NotNull()]
        public virtual IIS.Proekt.Участник Участник
        {
            get
            {
                // *** Start programmer edit section *** (Календарь.Участник Get start)

                // *** End programmer edit section *** (Календарь.Участник Get start)
                IIS.Proekt.Участник result = this.fУчастник;
                // *** Start programmer edit section *** (Календарь.Участник Get end)

                // *** End programmer edit section *** (Календарь.Участник Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Календарь.Участник Set start)

                // *** End programmer edit section *** (Календарь.Участник Set start)
                this.fУчастник = value;
                // *** Start programmer edit section *** (Календарь.Участник Set end)

                // *** End programmer edit section *** (Календарь.Участник Set end)
            }
        }
    }
}
