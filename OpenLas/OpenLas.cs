using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.GeoDatabaseExtensions;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geometry;

namespace OpenLas
{
    public partial class OpenLas : Form
    {
        public OpenLas()
        {
            ESRI.ArcGIS.RuntimeManager.Bind(ESRI.ArcGIS.ProductCode.EngineOrDesktop);
            InitializeComponent();
        }

        private void 创建LasdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog xjOpenFileDialog = new OpenFileDialog();
            xjOpenFileDialog.Filter += "点云数据(*.las)|*.las";

            if (xjOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string xjFileFullPath = xjOpenFileDialog.FileName;

                //创建lasd, ILasDatasetEdit  数据管理
                ILasDataset xjLasDataset = new LasDatasetClass();//using ESRI.ArcGIS.GeoDatabaseExtensions;
                ILasDatasetEdit xjLasDatasetEdit = xjLasDataset as ILasDatasetEdit;
                xjLasDatasetEdit.AddFile(xjFileFullPath);
                xjLasDataset.SaveAs(xjFileFullPath + "d", true);
                xjLasDatasetEdit.Save();
                MessageBox.Show("请执行下一步！！！");
            }
            else
            {
                return;
            }
        }

        private void 打开LasdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog xjOpenFileDialog = new OpenFileDialog();
            xjOpenFileDialog.Filter += "点云数据(*.lasd)|*.lasd";

            if (xjOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string xjFileFullPath = xjOpenFileDialog.FileName;
                string xjFilePath = System.IO.Path.GetDirectoryName(xjFileFullPath);
                string xjFileName = System.IO.Path.GetFileName(xjFileFullPath);

                IWorkspaceFactory xjWorkspaceFactory = new LasDatasetWorkspaceFactoryClass();//using ESRI.ArcGIS.Geodatabase;
                IWorkspace xjWorkspace = xjWorkspaceFactory.OpenFromFile(xjFilePath, 0);
                ILasDatasetWorkspace xjLasDatasetWorkspace = xjWorkspace as ILasDatasetWorkspace;
                ILasDataset xjLasDataset = xjLasDatasetWorkspace.OpenLasDataset(xjFileName);
                ILasDatasetLayer xjLasDatasetLayer = new LasDatasetLayerClass();//using ESRI.ArcGIS.Carto;
                xjLasDatasetLayer.Dataset = xjLasDataset;
                

                this.axMapControl1.AddLayer(xjLasDatasetLayer);
            }

        }

        private void 鼠标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IGeometry geometry = axMapControl1.TrackRectangle();
            axMapControl1.Map.SelectByShape(geometry, null, false);
            axMapControl1.Refresh(esriViewDrawPhase.esriViewGeoSelection, null, null);


            // 获取选择集  
            ISelection pSelection = axMapControl1.Map.FeatureSelection;

            // 打开属性标签  
            IEnumFeatureSetup pEnumFeatureSetup = pSelection as IEnumFeatureSetup;
            pEnumFeatureSetup.AllFields = true;
            // 获取要素  
            IEnumFeature pEnumFeature = pSelection as IEnumFeature;
            IFeature pFeature = pEnumFeature.Next();
            IFeatureLayer[] players = new IFeatureLayer[axMapControl1.LayerCount];

            FeatureLayer pFeatureLayer = new FeatureLayer();
            IFeatureLayer player = pFeatureLayer as IFeatureLayer;
            IFeatureSelection pFeatureSelection = pFeatureLayer as IFeatureSelection;
            while (pFeature != null)
            {
                //pFeatureSelection.Add(pFeature);
                pFeature = pEnumFeature.Next();
            }
        }




    }
}
