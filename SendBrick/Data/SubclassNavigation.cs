using System;
using System.Collections.Generic;
using System.Text;

namespace CM.SendBrick.Library.Data
{
    internal class SubclassNavigation
    {
        #region SubClassNavigationMethods
        public static bool FindFirstRecord<T>(ref int inpCurrentRecord,
                                              ref List<T> inpRecordList)
        {
            try
            {
                inpCurrentRecord = 0;
                T record = inpRecordList[inpCurrentRecord];

                return (record != null);
            }
            catch
            {
                throw;
            }
        }
        public static bool FindNextRecord<T>(ref int inpCurrentRecord,
                                             ref List<T> inpRecordList)
        {
            try
            {
                if (inpCurrentRecord == inpRecordList.Count - 1)
                {
                    return false;
                }

                inpCurrentRecord++;
                T record = inpRecordList[inpCurrentRecord];
                return (record != null);
            }
            catch
            {
                throw;
            }
        }
        public static bool FindPrevRecord<T>(ref int inpCurrentRecord,
                                             ref List<T> inpRecordList)
        {
            try
            {
                if (inpCurrentRecord == 0)
                {
                    return false;
                }

                inpCurrentRecord--;
                T record = inpRecordList[inpCurrentRecord];
                return (record != null);
            }
            catch
            {
                throw;
            }
        }
        public static bool FindLastRecord<T>(ref int inpCurrentRecord,
                                             ref List<T> inpRecordList)
        {
            try
            {
                inpCurrentRecord = inpRecordList.Count - 1;
                T record = inpRecordList[inpCurrentRecord];
                return (record != null);
            }
            catch
            {
                throw;
            }
        }
        public static bool FindSpecificRecord<T>(int inpParcelIndex,
                                                 ref int inpCurrentRecord,
                                                 ref List<T> inpRecordList)
        {
            try
            {
                if (inpParcelIndex < 0 || inpParcelIndex > inpRecordList.Count - 1)
                {
                    throw new IndexOutOfRangeException("There is no parcel at this position");
                }
                inpCurrentRecord = inpParcelIndex;
                T record = inpRecordList[inpCurrentRecord];
                return (record != null);
            }
            catch
            {
                throw;
            }
        }
        #endregion
    }
}
