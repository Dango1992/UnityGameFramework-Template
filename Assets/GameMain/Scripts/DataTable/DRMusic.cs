﻿using GameFramework;
using UnityGameFramework.Runtime;

namespace GameMain
{
    /// <summary>
    /// 音乐配置表。
    /// </summary>
    public class DRMusic : DataRowBase
    {
        private int m_Id = 0;

        /// <summary>
        /// 音乐编号。
        /// </summary>
        public override int Id
        {
            get
            {
                return m_Id;
            }
        }

        /// <summary>
        /// 资源名称。
        /// </summary>
        public string AssetName
        {
            get;
            private set;
        }

        public override bool ParseDataRow(GameFrameworkSegment<string> dataRowSegment)
        {
            string[] text = DataTableExtension.SplitDataRow(dataRowSegment);
            int index = 0;
            index++;
            m_Id = int.Parse(text[index++]);
            index++;
            AssetName = text[index++];

            return true;
        }
    }
}
