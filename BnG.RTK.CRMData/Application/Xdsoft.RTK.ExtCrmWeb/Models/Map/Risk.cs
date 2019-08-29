using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Xdsoft.RTK.ExtCrmWeb.Models.Map
{
    public class Risk
    {
        public string Name { get; set; }

        public DateTime DetectionDate { get; set; }

        private string propRiskStatus;

        public string Status
        {
            get { return propRiskStatus; }
            set { propRiskStatus = translateRiskStatus(value); }
        }

        private string propRespA;

        public string RespAction
        {
            get { return propRespA; }
            set { propRespA = translateRiskRespActionCode(value); }
        }

        private string propVar;

        public string Probability
        {
            get { return propVar; }
            set { propVar = translateRiskPropCode(value); }
        }

        private string propImp;

        public string Impact
        {
            get { return propImp; } 
            set { propImp = translateRiskImpactCode(value); }
        }

        private string convertDate(DateTime date) {
 
            return date.ToString("dd-MM-yyyy");
        }

        private string translateRiskPropCode(string propCode)
        {
            switch (propCode)
            {
                case "100000000":
                    return "Маловероятно";
                case "100000001":
                    return "Возможно";
                case "100000002":
                    return "Почти неизбежно";
                default:
                    return "Оценка вероятности риска отсутствует либо введена неверно";
            }
            //probability: если 100 000 000 == Маловероятно, если 100 000 001 == Возможно, если 100 000 002 == Почти неизбежно
        }

        private string translateRiskImpactCode(string impCode)
        {
            switch (impCode)
            {
                case "100000000":
                    return "Несущественное";
                case "100000001":
                    return "Умеренное";
                case "100000002":
                    return "Большое";
                default:
                    return "Оценка влияния риска отсутствует либо введена неверно";
            }
            //impact:      если 100 000 000 == Несущественное, если 100 000 001 == Умеренное, если 100 000 002 == Большое
        }

        private string translateRiskRespActionCode(string respActCode)
        {
            switch (respActCode)
            {
                case "100000000":
                    return "Не требует реагирование";
                case "100000001":
                    return "Мониторинг РФ";
                case "100000002":
                    return "Проактивное Реагирование";
                case "100000003":
                    return "Эскалация на уровень МРФ";
                case "100000004":
                    return "Эскалация на уровень КЦ";
                default:
                    return "Оценка меры реагирования отсутствует либо введена неверно";
            }
        }

        private string translateRiskStatus(string riskStatusCode) {
            switch (riskStatusCode)
            {
                case "1":
                    return "Идентифицирован";
                case "100000000":
                    return "Отслеживается";
                case "100000001":
                    return "Предотвращается";
                case "100000002":
                    return "Закрыт";
                default:
                    return "Статус реагирования отсутствует либо введен неверно"; ;
            }
        }
    }
}