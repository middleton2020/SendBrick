using System;
using System.Collections.Generic;
using System.Text;

namespace CM.SendBrick.Library.Data
{
    internal class SubclassNavigation
    {
        #region SubClassNavigationMethods
        /// <summary>
        /// Gets the first record in the specified list.
        /// </summary>
        /// <typeparam name="T">The type used for the return and inpRecordList</typeparam>
        /// <param name="inpCurrentRecord">A counter holding the current record in inpRecordList</param>
        /// <param name="inpRecordList">A list of type T objects to navigate through</param>
        /// <returns>An object of type T from the inpRecordList</returns>
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

        /// <summary>
        /// Gets the next record in the specified list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="inpCurrentRecord"></param>
        /// <param name="inpRecordList"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets the previous record in the specified list.
        /// </summary>
        /// <typeparam name="T">The type used for the return and inpRecordList</typeparam>
        /// <param name="inpCurrentRecord">A counter holding the current record in inpRecordList</param>
        /// <param name="inpRecordList">A list of type T objects to navigate through</param>
        /// <returns>An object of type T from the inpRecordList</returns>
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

        /// <summary>
        /// Gets the Last record in the specified list.
        /// </summary>
        /// <typeparam name="T">The type used for the return and inpRecordList</typeparam>
        /// <param name="inpCurrentRecord">A counter holding the current record in inpRecordList</param>
        /// <param name="inpRecordList">A list of type T objects to navigate through</param>
        /// <returns>An object of type T from the inpRecordList</returns>
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

        /// <summary>
        /// Gets a specified record in the specified list.
        /// </summary>
        /// <typeparam name="T">The type used for the return and inpRecordList</typeparam>
        /// <param name="inpParcelIndex">The index that you want to find in inpRecordList</param>
        /// <param name="inpCurrentRecord">A counter holding the current record in inpRecordList</param>
        /// <param name="inpRecordList">A list of type T objects to navigate through</param>
        /// <returns>An object of type T from the inpRecordList</returns>
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
