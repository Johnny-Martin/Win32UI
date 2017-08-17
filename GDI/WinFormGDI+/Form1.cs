using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.IO;
using System.Reflection;

using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
namespace GDIPlusDemo
{
    /// <summary>
    /// Form1 的摘要说明。
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem FadeInOut;
        private System.Windows.Forms.MenuItem GrayScale;
        private System.Windows.Forms.MenuItem Inverse;
        private System.Windows.Forms.MenuItem Emboss;
        private System.Windows.Forms.MenuItem CreatePenFromBrush;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem DashStyle_Custom;
        private System.Windows.Forms.MenuItem Pen_Align;
        private System.Windows.Forms.MenuItem Pen_Tranform;
        private System.Windows.Forms.MenuItem Pen_LineCap;
        private System.Windows.Forms.MenuItem Pen_TransColor;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem Brush_SolidBrush;
        private System.Windows.Forms.MenuItem Brush_FillVurve;
        private System.Windows.Forms.MenuItem Brush_HatchBrush;
        private System.Windows.Forms.MenuItem Brush_EnumAllStyle;
        private System.Windows.Forms.MenuItem Brush_SetRenderingOrigin;
        private System.Windows.Forms.MenuItem Brush_Texture;
        private System.Windows.Forms.MenuItem Brush_Texture_WrapMode;
        private System.Windows.Forms.MenuItem Brush_TextureTransform;
        private System.Windows.Forms.MenuItem Brush_GetTextureMatrix;
        private System.Windows.Forms.MenuItem Brush_LinearGradientBrush;
        private System.Windows.Forms.MenuItem Brush_LinearArrange;
        private System.Windows.Forms.MenuItem Brush_LinearGradientMode;
        private System.Windows.Forms.MenuItem Brush_LinearAngle;
        private System.Windows.Forms.MenuItem Brush_LinearInterpolation;
        private System.Windows.Forms.MenuItem Brush_LinearCustomize;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem Brush_LinearGradientBrush_BellShape;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem Brush_PathGradientBrush_Star;
        private System.Windows.Forms.MenuItem Brush_PathGradientBrush_Star2;
        private System.Windows.Forms.MenuItem Brush_Using_MorePathGradientBrush;
        private System.Windows.Forms.MenuItem Brush_PathGradientBrush_WrapMode;
        private System.Windows.Forms.MenuItem Brush_PathGradientBrush_CenterPoint;
        private System.Windows.Forms.MenuItem Brush_PathGradientBrush_InterpolationColors;
        private System.Windows.Forms.MenuItem Brsuh_PathGradietBrush_Focus;
        private System.Windows.Forms.MenuItem Brush_PathGradientBrush_Transform;
        private System.Windows.Forms.MenuItem Brsuh_LinearGradientBrush_UsingGamma;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem Font_UsingFontInGDIPlus;
        private System.Windows.Forms.MenuItem Font_EnumAllFonts;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem Font_EnhanceFontDialog;
        private System.Windows.Forms.MenuItem Font_UsingTextRenderHint;
        private System.Windows.Forms.MenuItem Font_Privatefontcollection;
        private System.Windows.Forms.MenuItem Font_Privatefontcollection2;
        private System.Windows.Forms.MenuItem Font_IsStyleAvailable;
        private System.Windows.Forms.MenuItem Font_Size;
        private System.Windows.Forms.MenuItem Font_BaseLine;
        private System.Windows.Forms.MenuItem Font_DrawString;
        private System.Windows.Forms.MenuItem Font_MeasureString;
        private System.Windows.Forms.MenuItem Font_MeasureString2;
        private System.Windows.Forms.MenuItem Font_ColumnTextOut;
        private System.Windows.Forms.MenuItem Font_StirngTrimming;
        private System.Windows.Forms.MenuItem Font_TextOutClip;
        private System.Windows.Forms.MenuItem Font_MeasureCharacterRanges;
        private System.Windows.Forms.MenuItem Font_TextoutDirection;
        private System.Windows.Forms.MenuItem Font_TextAlignment;
        private System.Windows.Forms.MenuItem Font_TextAlignment2;
        private System.Windows.Forms.MenuItem Font_TextoutUsingTabs;
        private System.Windows.Forms.MenuItem Font_UsingTabs;
        private System.Windows.Forms.MenuItem Font_TextoutHotkeyPrefix;
        private System.Windows.Forms.MenuItem Font_TextoutShadow;
        private System.Windows.Forms.MenuItem Font_TextoutHashline;
        private System.Windows.Forms.MenuItem Font_TextoutTexture;
        private System.Windows.Forms.MenuItem Font_TextoutGradient;
        private System.Windows.Forms.MenuItem Path_Construct;
        private System.Windows.Forms.MenuItem Path_AddLines;
        private System.Windows.Forms.MenuItem Path_CloseFigure;
        private System.Windows.Forms.MenuItem Path_FillPath;
        private System.Windows.Forms.MenuItem Path_AddSubPath;
        private System.Windows.Forms.MenuItem Path_GetSubPath;
        private System.Windows.Forms.MenuItem Path_GetPoints;
        private System.Windows.Forms.MenuItem Path_PathData;
        private System.Windows.Forms.MenuItem Path_ViewPointFLAG;
        private System.Windows.Forms.MenuItem Path_SubPathRange;
        private System.Windows.Forms.MenuItem Path＿Flatten;
        private System.Windows.Forms.MenuItem Path_Warp;
        private System.Windows.Forms.MenuItem Path_Transform;
        private System.Windows.Forms.MenuItem Path_Widen;
        private System.Windows.Forms.MenuItem Path_WidenDemo;
        private System.Windows.Forms.MenuItem Region＿FromPath;
        private System.Windows.Forms.MenuItem Region_Calculate;
        private System.Windows.Forms.MenuItem Region_GetRects;
        private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.MenuItem Transform;
        private System.Windows.Forms.MenuItem TranslateTransform;
        private System.Windows.Forms.MenuItem RotateTransform;
        private System.Windows.Forms.MenuItem DrawWatch;
        private System.Windows.Forms.MenuItem ScaleTransform;
        private System.Windows.Forms.MenuItem RectScale;
        private System.Windows.Forms.MenuItem FontRotate;
        private System.Windows.Forms.MenuItem Matrix_ListElements;
        private System.Windows.Forms.MenuItem MatrixPos;
        private System.Windows.Forms.MenuItem Martrix_Invert;
        private System.Windows.Forms.MenuItem Matrix_Multiply;
        private System.Windows.Forms.MenuItem Matrix_TransformPoints;
        private System.Windows.Forms.MenuItem Matrix_TransformPoints2;
        private System.Windows.Forms.MenuItem Matrix_TransformVectors;
        private System.Windows.Forms.MenuItem Matrix_RotateAt;
        private System.Windows.Forms.MenuItem Matrix_Shear;
        private System.Windows.Forms.MenuItem Matrix_TextoutShear;
        private System.Windows.Forms.MenuItem Matrix_ChangeFontHeight;
        private System.Windows.Forms.MenuItem menuItem12;
        private System.Windows.Forms.MenuItem ColorMatrix＿Start;
        private System.Windows.Forms.MenuItem TranslateColor;
        private System.Windows.Forms.MenuItem ScaleColor;
        private System.Windows.Forms.MenuItem RotateColor;
        private System.Windows.Forms.MenuItem ColorShear;
        private System.Windows.Forms.MenuItem ColorRemap;
        private System.Windows.Forms.MenuItem SetRGBOutputChannel;
        private System.Windows.Forms.MenuItem menuItem13;
        private System.Windows.Forms.MenuItem Metafile;
        private System.Windows.Forms.MenuItem CroppingAndScaling;
        private System.Windows.Forms.MenuItem UsingInterpolationMode;
        private System.Windows.Forms.MenuItem RotateFlip;
        private System.Windows.Forms.MenuItem ImageSkewing;
        private System.Windows.Forms.MenuItem Cubeimage;
        private System.Windows.Forms.MenuItem ThumbnailImage;
        private System.Windows.Forms.MenuItem Clone;
        private System.Windows.Forms.MenuItem Picturescale;
        private System.Windows.Forms.MenuItem menuItem15;
        private System.Windows.Forms.MenuItem ImageAttributesSetNoOp;
        private System.Windows.Forms.MenuItem SetColorMatrices;
        private System.Windows.Forms.MenuItem SetOutputChannelColorProfile;
        private System.Windows.Forms.MenuItem Gammaadjust;
        private System.Windows.Forms.MenuItem SetOutputChannel;
        private System.Windows.Forms.MenuItem Colorkey;
        private System.Windows.Forms.MenuItem Setthreshold;
        private System.Windows.Forms.MenuItem AdjustedPalette;
        private System.Windows.Forms.MenuItem SetWrapMode;
        private System.Windows.Forms.MenuItem menuItem16;
        private System.Windows.Forms.MenuItem ListAllImageEncoders;
        private System.Windows.Forms.MenuItem ListImageEncoder_Detail;
        private System.Windows.Forms.MenuItem ListImageDecoder;
        private System.Windows.Forms.MenuItem GetEncoderParameter;
        private System.Windows.Forms.MenuItem GetAllEncoderParameter;
        private System.Windows.Forms.MenuItem menuItem17;
        private System.Windows.Forms.MenuItem MultipleFrameImage;
        private System.Windows.Forms.MenuItem SaveBmp2tif;
        private System.Windows.Forms.MenuItem SaveBMP2JPG;
        private System.Windows.Forms.MenuItem TransformingJPEG;
        private System.Windows.Forms.MenuItem GetImageFromMultyFrame;
        private System.Windows.Forms.MenuItem QueryImage;
        private System.Windows.Forms.MenuItem SetProp;
        private System.Windows.Forms.MenuItem menuItem18;
        private System.Windows.Forms.MenuItem OnCanvas;
        private System.Windows.Forms.MenuItem OnWood;
        private System.Windows.Forms.MenuItem Flashligt;
        private System.Windows.Forms.MenuItem BlurAndSharpen;
        private IContainer components;

        public Form1()
        {
            //
            // Windows 窗体设计器支持所必需的
            //
            InitializeComponent();


            //
            // TODO: 在 InitializeComponent 调用后添加任何构造函数代码
            //
        }

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// 设计器支持所需的方法 - 不要使用代码编辑器修改
        /// 此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.CreatePenFromBrush = new System.Windows.Forms.MenuItem();
            this.DashStyle_Custom = new System.Windows.Forms.MenuItem();
            this.Pen_Align = new System.Windows.Forms.MenuItem();
            this.Pen_Tranform = new System.Windows.Forms.MenuItem();
            this.Pen_LineCap = new System.Windows.Forms.MenuItem();
            this.Pen_TransColor = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.Brush_SolidBrush = new System.Windows.Forms.MenuItem();
            this.Brush_FillVurve = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.Brush_HatchBrush = new System.Windows.Forms.MenuItem();
            this.Brush_EnumAllStyle = new System.Windows.Forms.MenuItem();
            this.Brush_SetRenderingOrigin = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.Brush_Texture = new System.Windows.Forms.MenuItem();
            this.Brush_Texture_WrapMode = new System.Windows.Forms.MenuItem();
            this.Brush_TextureTransform = new System.Windows.Forms.MenuItem();
            this.Brush_GetTextureMatrix = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.Brush_LinearGradientBrush = new System.Windows.Forms.MenuItem();
            this.Brush_LinearArrange = new System.Windows.Forms.MenuItem();
            this.Brush_LinearInterpolation = new System.Windows.Forms.MenuItem();
            this.Brush_LinearGradientMode = new System.Windows.Forms.MenuItem();
            this.Brush_LinearAngle = new System.Windows.Forms.MenuItem();
            this.Brush_LinearCustomize = new System.Windows.Forms.MenuItem();
            this.Brush_LinearGradientBrush_BellShape = new System.Windows.Forms.MenuItem();
            this.Brsuh_LinearGradientBrush_UsingGamma = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.Brush_PathGradientBrush_Star = new System.Windows.Forms.MenuItem();
            this.Brush_PathGradientBrush_Star2 = new System.Windows.Forms.MenuItem();
            this.Brush_Using_MorePathGradientBrush = new System.Windows.Forms.MenuItem();
            this.Brush_PathGradientBrush_WrapMode = new System.Windows.Forms.MenuItem();
            this.Brush_PathGradientBrush_CenterPoint = new System.Windows.Forms.MenuItem();
            this.Brush_PathGradientBrush_InterpolationColors = new System.Windows.Forms.MenuItem();
            this.Brsuh_PathGradietBrush_Focus = new System.Windows.Forms.MenuItem();
            this.Brush_PathGradientBrush_Transform = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.Font_UsingFontInGDIPlus = new System.Windows.Forms.MenuItem();
            this.Font_EnumAllFonts = new System.Windows.Forms.MenuItem();
            this.Font_EnhanceFontDialog = new System.Windows.Forms.MenuItem();
            this.Font_UsingTextRenderHint = new System.Windows.Forms.MenuItem();
            this.Font_Privatefontcollection = new System.Windows.Forms.MenuItem();
            this.Font_Privatefontcollection2 = new System.Windows.Forms.MenuItem();
            this.Font_IsStyleAvailable = new System.Windows.Forms.MenuItem();
            this.Font_Size = new System.Windows.Forms.MenuItem();
            this.Font_BaseLine = new System.Windows.Forms.MenuItem();
            this.Font_DrawString = new System.Windows.Forms.MenuItem();
            this.Font_MeasureString = new System.Windows.Forms.MenuItem();
            this.Font_MeasureString2 = new System.Windows.Forms.MenuItem();
            this.Font_ColumnTextOut = new System.Windows.Forms.MenuItem();
            this.Font_StirngTrimming = new System.Windows.Forms.MenuItem();
            this.Font_TextOutClip = new System.Windows.Forms.MenuItem();
            this.Font_MeasureCharacterRanges = new System.Windows.Forms.MenuItem();
            this.Font_TextoutDirection = new System.Windows.Forms.MenuItem();
            this.Font_TextAlignment = new System.Windows.Forms.MenuItem();
            this.Font_TextAlignment2 = new System.Windows.Forms.MenuItem();
            this.Font_TextoutUsingTabs = new System.Windows.Forms.MenuItem();
            this.Font_UsingTabs = new System.Windows.Forms.MenuItem();
            this.Font_TextoutHotkeyPrefix = new System.Windows.Forms.MenuItem();
            this.Font_TextoutShadow = new System.Windows.Forms.MenuItem();
            this.Font_TextoutHashline = new System.Windows.Forms.MenuItem();
            this.Font_TextoutTexture = new System.Windows.Forms.MenuItem();
            this.Font_TextoutGradient = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.Path_Construct = new System.Windows.Forms.MenuItem();
            this.Path_AddLines = new System.Windows.Forms.MenuItem();
            this.Path_CloseFigure = new System.Windows.Forms.MenuItem();
            this.Path_FillPath = new System.Windows.Forms.MenuItem();
            this.Path_AddSubPath = new System.Windows.Forms.MenuItem();
            this.Path_GetSubPath = new System.Windows.Forms.MenuItem();
            this.Path_GetPoints = new System.Windows.Forms.MenuItem();
            this.Path_PathData = new System.Windows.Forms.MenuItem();
            this.Path_ViewPointFLAG = new System.Windows.Forms.MenuItem();
            this.Path_SubPathRange = new System.Windows.Forms.MenuItem();
            this.Path＿Flatten = new System.Windows.Forms.MenuItem();
            this.Path_Warp = new System.Windows.Forms.MenuItem();
            this.Path_Transform = new System.Windows.Forms.MenuItem();
            this.Path_Widen = new System.Windows.Forms.MenuItem();
            this.Path_WidenDemo = new System.Windows.Forms.MenuItem();
            this.Region＿FromPath = new System.Windows.Forms.MenuItem();
            this.Region_Calculate = new System.Windows.Forms.MenuItem();
            this.Region_GetRects = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.Transform = new System.Windows.Forms.MenuItem();
            this.TranslateTransform = new System.Windows.Forms.MenuItem();
            this.RotateTransform = new System.Windows.Forms.MenuItem();
            this.DrawWatch = new System.Windows.Forms.MenuItem();
            this.ScaleTransform = new System.Windows.Forms.MenuItem();
            this.RectScale = new System.Windows.Forms.MenuItem();
            this.FontRotate = new System.Windows.Forms.MenuItem();
            this.Matrix_ListElements = new System.Windows.Forms.MenuItem();
            this.MatrixPos = new System.Windows.Forms.MenuItem();
            this.Martrix_Invert = new System.Windows.Forms.MenuItem();
            this.Matrix_Multiply = new System.Windows.Forms.MenuItem();
            this.Matrix_TransformPoints = new System.Windows.Forms.MenuItem();
            this.Matrix_TransformPoints2 = new System.Windows.Forms.MenuItem();
            this.Matrix_TransformVectors = new System.Windows.Forms.MenuItem();
            this.Matrix_RotateAt = new System.Windows.Forms.MenuItem();
            this.Matrix_Shear = new System.Windows.Forms.MenuItem();
            this.Matrix_TextoutShear = new System.Windows.Forms.MenuItem();
            this.Matrix_ChangeFontHeight = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.ColorMatrix＿Start = new System.Windows.Forms.MenuItem();
            this.TranslateColor = new System.Windows.Forms.MenuItem();
            this.ScaleColor = new System.Windows.Forms.MenuItem();
            this.RotateColor = new System.Windows.Forms.MenuItem();
            this.ColorShear = new System.Windows.Forms.MenuItem();
            this.ColorRemap = new System.Windows.Forms.MenuItem();
            this.SetRGBOutputChannel = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.Metafile = new System.Windows.Forms.MenuItem();
            this.CroppingAndScaling = new System.Windows.Forms.MenuItem();
            this.UsingInterpolationMode = new System.Windows.Forms.MenuItem();
            this.RotateFlip = new System.Windows.Forms.MenuItem();
            this.ImageSkewing = new System.Windows.Forms.MenuItem();
            this.Cubeimage = new System.Windows.Forms.MenuItem();
            this.ThumbnailImage = new System.Windows.Forms.MenuItem();
            this.Clone = new System.Windows.Forms.MenuItem();
            this.Picturescale = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.ImageAttributesSetNoOp = new System.Windows.Forms.MenuItem();
            this.SetColorMatrices = new System.Windows.Forms.MenuItem();
            this.SetOutputChannelColorProfile = new System.Windows.Forms.MenuItem();
            this.Gammaadjust = new System.Windows.Forms.MenuItem();
            this.SetOutputChannel = new System.Windows.Forms.MenuItem();
            this.Colorkey = new System.Windows.Forms.MenuItem();
            this.Setthreshold = new System.Windows.Forms.MenuItem();
            this.AdjustedPalette = new System.Windows.Forms.MenuItem();
            this.SetWrapMode = new System.Windows.Forms.MenuItem();
            this.menuItem16 = new System.Windows.Forms.MenuItem();
            this.ListAllImageEncoders = new System.Windows.Forms.MenuItem();
            this.ListImageEncoder_Detail = new System.Windows.Forms.MenuItem();
            this.ListImageDecoder = new System.Windows.Forms.MenuItem();
            this.GetEncoderParameter = new System.Windows.Forms.MenuItem();
            this.GetAllEncoderParameter = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.SaveBmp2tif = new System.Windows.Forms.MenuItem();
            this.SaveBMP2JPG = new System.Windows.Forms.MenuItem();
            this.TransformingJPEG = new System.Windows.Forms.MenuItem();
            this.MultipleFrameImage = new System.Windows.Forms.MenuItem();
            this.GetImageFromMultyFrame = new System.Windows.Forms.MenuItem();
            this.QueryImage = new System.Windows.Forms.MenuItem();
            this.SetProp = new System.Windows.Forms.MenuItem();
            this.menuItem18 = new System.Windows.Forms.MenuItem();
            this.FadeInOut = new System.Windows.Forms.MenuItem();
            this.GrayScale = new System.Windows.Forms.MenuItem();
            this.Inverse = new System.Windows.Forms.MenuItem();
            this.Emboss = new System.Windows.Forms.MenuItem();
            this.OnCanvas = new System.Windows.Forms.MenuItem();
            this.OnWood = new System.Windows.Forms.MenuItem();
            this.Flashligt = new System.Windows.Forms.MenuItem();
            this.BlurAndSharpen = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem3,
            this.menuItem8,
            this.menuItem9,
            this.menuItem11,
            this.menuItem12,
            this.menuItem13,
            this.menuItem15,
            this.menuItem16,
            this.menuItem18});
            this.menuItem1.Text = "GDI+编程";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.CreatePenFromBrush,
            this.DashStyle_Custom,
            this.Pen_Align,
            this.Pen_Tranform,
            this.Pen_LineCap,
            this.Pen_TransColor});
            this.menuItem2.Text = "画笔";
            // 
            // CreatePenFromBrush
            // 
            this.CreatePenFromBrush.Index = 0;
            this.CreatePenFromBrush.Text = "从画刷中构造画笔";
            this.CreatePenFromBrush.Click += new System.EventHandler(this.CreatePenFromBrush_Click);
            // 
            // DashStyle_Custom
            // 
            this.DashStyle_Custom.Index = 1;
            this.DashStyle_Custom.Text = "自定义线型";
            this.DashStyle_Custom.Click += new System.EventHandler(this.DashStyle_Custom_Click);
            // 
            // Pen_Align
            // 
            this.Pen_Align.Index = 2;
            this.Pen_Align.Text = "画笔的对齐方式";
            this.Pen_Align.Click += new System.EventHandler(this.Pen_Align_Click);
            // 
            // Pen_Tranform
            // 
            this.Pen_Tranform.Index = 3;
            this.Pen_Tranform.Text = "画笔的缩放与旋转";
            this.Pen_Tranform.Click += new System.EventHandler(this.Pen_Tranform_Click);
            // 
            // Pen_LineCap
            // 
            this.Pen_LineCap.Index = 4;
            this.Pen_LineCap.Text = "画笔的线帽属性";
            this.Pen_LineCap.Click += new System.EventHandler(this.Pen_LineCap_Click);
            // 
            // Pen_TransColor
            // 
            this.Pen_TransColor.Index = 5;
            this.Pen_TransColor.Text = "画笔的透明度支持";
            this.Pen_TransColor.Click += new System.EventHandler(this.Pen_TransColor_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem5,
            this.menuItem10,
            this.menuItem7,
            this.menuItem6,
            this.menuItem4});
            this.menuItem3.Text = "画刷";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 0;
            this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Brush_SolidBrush,
            this.Brush_FillVurve});
            this.menuItem5.Text = "单色画刷的使用";
            // 
            // Brush_SolidBrush
            // 
            this.Brush_SolidBrush.Index = 0;
            this.Brush_SolidBrush.Text = "简单的单色画刷";
            this.Brush_SolidBrush.Click += new System.EventHandler(this.Brush_SolidBrush_Click);
            // 
            // Brush_FillVurve
            // 
            this.Brush_FillVurve.Index = 1;
            this.Brush_FillVurve.Text = "填充正叶曲线";
            this.Brush_FillVurve.Click += new System.EventHandler(this.Brush_FillVurve_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 1;
            this.menuItem10.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Brush_HatchBrush,
            this.Brush_EnumAllStyle,
            this.Brush_SetRenderingOrigin});
            this.menuItem10.Text = "影线画刷的使用";
            // 
            // Brush_HatchBrush
            // 
            this.Brush_HatchBrush.Index = 0;
            this.Brush_HatchBrush.Text = "影线画刷";
            this.Brush_HatchBrush.Click += new System.EventHandler(this.Brush_HatchBrush_Click);
            // 
            // Brush_EnumAllStyle
            // 
            this.Brush_EnumAllStyle.Index = 1;
            this.Brush_EnumAllStyle.Text = "枚举所有影线画刷风格";
            this.Brush_EnumAllStyle.Click += new System.EventHandler(this.Brush_EnumAllStyle_Click);
            // 
            // Brush_SetRenderingOrigin
            // 
            this.Brush_SetRenderingOrigin.Index = 2;
            this.Brush_SetRenderingOrigin.Text = "设置绘制原点";
            this.Brush_SetRenderingOrigin.Click += new System.EventHandler(this.Brush_SetRenderingOrigin_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 2;
            this.menuItem7.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Brush_Texture,
            this.Brush_Texture_WrapMode,
            this.Brush_TextureTransform,
            this.Brush_GetTextureMatrix});
            this.menuItem7.Text = "纹理画刷";
            // 
            // Brush_Texture
            // 
            this.Brush_Texture.Index = 0;
            this.Brush_Texture.Text = "纹理画刷的基本使用";
            this.Brush_Texture.Click += new System.EventHandler(this.Brush_Texture_Click);
            // 
            // Brush_Texture_WrapMode
            // 
            this.Brush_Texture_WrapMode.Index = 1;
            this.Brush_Texture_WrapMode.Text = "纹理画刷的排列方式";
            this.Brush_Texture_WrapMode.Click += new System.EventHandler(this.Brush_Texture_WrapMode_Click);
            // 
            // Brush_TextureTransform
            // 
            this.Brush_TextureTransform.Index = 2;
            this.Brush_TextureTransform.Text = "纹理画刷的变换";
            this.Brush_TextureTransform.Click += new System.EventHandler(this.Brush_TextureTransform_Click);
            // 
            // Brush_GetTextureMatrix
            // 
            this.Brush_GetTextureMatrix.Index = 3;
            this.Brush_GetTextureMatrix.Text = "查询画刷的变换信息";
            this.Brush_GetTextureMatrix.Click += new System.EventHandler(this.Brush_GetTextureMatrix_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 3;
            this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Brush_LinearGradientBrush,
            this.Brush_LinearArrange,
            this.Brush_LinearInterpolation,
            this.Brush_LinearGradientMode,
            this.Brush_LinearAngle,
            this.Brush_LinearCustomize,
            this.Brush_LinearGradientBrush_BellShape,
            this.Brsuh_LinearGradientBrush_UsingGamma});
            this.menuItem6.Text = "线性渐变画刷的使用";
            // 
            // Brush_LinearGradientBrush
            // 
            this.Brush_LinearGradientBrush.Index = 0;
            this.Brush_LinearGradientBrush.Text = "线性渐变画刷";
            this.Brush_LinearGradientBrush.Click += new System.EventHandler(this.Brush_LinearGradientBrush_Click);
            // 
            // Brush_LinearArrange
            // 
            this.Brush_LinearArrange.Index = 1;
            this.Brush_LinearArrange.Text = "渐变画刷的不同填充方式";
            this.Brush_LinearArrange.Click += new System.EventHandler(this.Brush_LinearArrange_Click);
            // 
            // Brush_LinearInterpolation
            // 
            this.Brush_LinearInterpolation.Index = 2;
            this.Brush_LinearInterpolation.Text = "多色渐变画刷";
            this.Brush_LinearInterpolation.Click += new System.EventHandler(this.Brush_LinearInterpolation_Click);
            // 
            // Brush_LinearGradientMode
            // 
            this.Brush_LinearGradientMode.Index = 3;
            this.Brush_LinearGradientMode.Text = "使用渐变画刷的渐变模式";
            this.Brush_LinearGradientMode.Click += new System.EventHandler(this.Brush_LinearGradientMode_Click);
            // 
            // Brush_LinearAngle
            // 
            this.Brush_LinearAngle.Index = 4;
            this.Brush_LinearAngle.Text = "调整渐变线偏转角度";
            this.Brush_LinearAngle.Click += new System.EventHandler(this.Brush_LinearAngle_Click);
            // 
            // Brush_LinearCustomize
            // 
            this.Brush_LinearCustomize.Index = 5;
            this.Brush_LinearCustomize.Text = "自定义线性渐变画刷的渐变过程";
            this.Brush_LinearCustomize.Click += new System.EventHandler(this.Brush_LinearCustomize_Click);
            // 
            // Brush_LinearGradientBrush_BellShape
            // 
            this.Brush_LinearGradientBrush_BellShape.Index = 6;
            this.Brush_LinearGradientBrush_BellShape.Text = "钟形曲线渐变";
            this.Brush_LinearGradientBrush_BellShape.Click += new System.EventHandler(this.Brush_LinearGradientBrush_BellShape_Click);
            // 
            // Brsuh_LinearGradientBrush_UsingGamma
            // 
            this.Brsuh_LinearGradientBrush_UsingGamma.Index = 7;
            this.Brsuh_LinearGradientBrush_UsingGamma.Text = "启用Gamma校正";
            this.Brsuh_LinearGradientBrush_UsingGamma.Click += new System.EventHandler(this.Brsuh_LinearGradientBrush_UsingGamma_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 4;
            this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Brush_PathGradientBrush_Star,
            this.Brush_PathGradientBrush_Star2,
            this.Brush_Using_MorePathGradientBrush,
            this.Brush_PathGradientBrush_WrapMode,
            this.Brush_PathGradientBrush_CenterPoint,
            this.Brush_PathGradientBrush_InterpolationColors,
            this.Brsuh_PathGradietBrush_Focus,
            this.Brush_PathGradientBrush_Transform});
            this.menuItem4.Text = "路径渐变画刷";
            // 
            // Brush_PathGradientBrush_Star
            // 
            this.Brush_PathGradientBrush_Star.Index = 0;
            this.Brush_PathGradientBrush_Star.Text = "构造五星";
            this.Brush_PathGradientBrush_Star.Click += new System.EventHandler(this.Brush_PathGradientBrush_Star_Click);
            // 
            // Brush_PathGradientBrush_Star2
            // 
            this.Brush_PathGradientBrush_Star2.Index = 1;
            this.Brush_PathGradientBrush_Star2.Text = "构造五星(2)";
            this.Brush_PathGradientBrush_Star2.Click += new System.EventHandler(this.Brush_PathGradientBrush_Star2_Click);
            // 
            // Brush_Using_MorePathGradientBrush
            // 
            this.Brush_Using_MorePathGradientBrush.Index = 2;
            this.Brush_Using_MorePathGradientBrush.Text = "使用不同的路径渐变画刷";
            this.Brush_Using_MorePathGradientBrush.Click += new System.EventHandler(this.Brush_Using_MorePathGradientBrush_Click);
            // 
            // Brush_PathGradientBrush_WrapMode
            // 
            this.Brush_PathGradientBrush_WrapMode.Index = 3;
            this.Brush_PathGradientBrush_WrapMode.Text = "路径渐变画刷的排列方式";
            this.Brush_PathGradientBrush_WrapMode.Click += new System.EventHandler(this.Brush_PathGradientBrush_WrapMode_Click);
            // 
            // Brush_PathGradientBrush_CenterPoint
            // 
            this.Brush_PathGradientBrush_CenterPoint.Index = 4;
            this.Brush_PathGradientBrush_CenterPoint.Text = "更改路径渐变画刷的中心点";
            this.Brush_PathGradientBrush_CenterPoint.Click += new System.EventHandler(this.Brush_PathGradientBrush_CenterPoint_Click);
            // 
            // Brush_PathGradientBrush_InterpolationColors
            // 
            this.Brush_PathGradientBrush_InterpolationColors.Index = 5;
            this.Brush_PathGradientBrush_InterpolationColors.Text = "使用多色渐变";
            this.Brush_PathGradientBrush_InterpolationColors.Click += new System.EventHandler(this.Brush_PathGradientBrush_InterpolationColors_Click);
            // 
            // Brsuh_PathGradietBrush_Focus
            // 
            this.Brsuh_PathGradietBrush_Focus.Index = 6;
            this.Brsuh_PathGradietBrush_Focus.Text = "更改画刷的焦点缩放比例";
            this.Brsuh_PathGradietBrush_Focus.Click += new System.EventHandler(this.Brsuh_PathGradietBrush_Focus_Click);
            // 
            // Brush_PathGradientBrush_Transform
            // 
            this.Brush_PathGradientBrush_Transform.Index = 7;
            this.Brush_PathGradientBrush_Transform.Text = "路径渐变画刷的变换";
            this.Brush_PathGradientBrush_Transform.Click += new System.EventHandler(this.Brush_PathGradientBrush_Transform_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 2;
            this.menuItem8.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Font_UsingFontInGDIPlus,
            this.Font_EnumAllFonts,
            this.Font_EnhanceFontDialog,
            this.Font_UsingTextRenderHint,
            this.Font_Privatefontcollection,
            this.Font_Privatefontcollection2,
            this.Font_IsStyleAvailable,
            this.Font_Size,
            this.Font_BaseLine,
            this.Font_DrawString,
            this.Font_MeasureString,
            this.Font_MeasureString2,
            this.Font_ColumnTextOut,
            this.Font_StirngTrimming,
            this.Font_TextOutClip,
            this.Font_MeasureCharacterRanges,
            this.Font_TextoutDirection,
            this.Font_TextAlignment,
            this.Font_TextAlignment2,
            this.Font_TextoutUsingTabs,
            this.Font_UsingTabs,
            this.Font_TextoutHotkeyPrefix,
            this.Font_TextoutShadow,
            this.Font_TextoutHashline,
            this.Font_TextoutTexture,
            this.Font_TextoutGradient});
            this.menuItem8.Text = "文本与字体";
            // 
            // Font_UsingFontInGDIPlus
            // 
            this.Font_UsingFontInGDIPlus.Index = 0;
            this.Font_UsingFontInGDIPlus.Text = "在GDI+中使用字体(&A)";
            this.Font_UsingFontInGDIPlus.Click += new System.EventHandler(this.Font_UsingFontInGDIPlus_Click);
            // 
            // Font_EnumAllFonts
            // 
            this.Font_EnumAllFonts.Index = 1;
            this.Font_EnumAllFonts.Text = "获取已安装的字体";
            this.Font_EnumAllFonts.Click += new System.EventHandler(this.Font_EnumAllFonts_Click);
            // 
            // Font_EnhanceFontDialog
            // 
            this.Font_EnhanceFontDialog.Index = 2;
            this.Font_EnhanceFontDialog.Text = "增强型字体选择对话框";
            this.Font_EnhanceFontDialog.Click += new System.EventHandler(this.Font_EnhanceFontDialog_Click);
            // 
            // Font_UsingTextRenderHint
            // 
            this.Font_UsingTextRenderHint.Index = 3;
            this.Font_UsingTextRenderHint.Text = "设置字体的边缘处理方式";
            this.Font_UsingTextRenderHint.Click += new System.EventHandler(this.Font_UsingTextRenderHint_Click);
            // 
            // Font_Privatefontcollection
            // 
            this.Font_Privatefontcollection.Index = 4;
            this.Font_Privatefontcollection.Text = "使用私有字体集合";
            this.Font_Privatefontcollection.Click += new System.EventHandler(this.Font_Privatefontcollection_Click);
            // 
            // Font_Privatefontcollection2
            // 
            this.Font_Privatefontcollection2.Index = 5;
            this.Font_Privatefontcollection2.Text = "在私有字体集合中使用多个字体";
            this.Font_Privatefontcollection2.Click += new System.EventHandler(this.Font_Privatefontcollection2_Click);
            // 
            // Font_IsStyleAvailable
            // 
            this.Font_IsStyleAvailable.Index = 6;
            this.Font_IsStyleAvailable.Text = "在私有字体集合中检查字体信息的可用性";
            this.Font_IsStyleAvailable.Click += new System.EventHandler(this.Font_IsStyleAvailable_Click);
            // 
            // Font_Size
            // 
            this.Font_Size.Index = 7;
            this.Font_Size.Text = "在程序中访问字体(系列)的大小信息";
            this.Font_Size.Click += new System.EventHandler(this.Font_Size_Click);
            // 
            // Font_BaseLine
            // 
            this.Font_BaseLine.Index = 8;
            this.Font_BaseLine.Text = "设置文本输出的基线";
            this.Font_BaseLine.Click += new System.EventHandler(this.Font_BaseLine_Click);
            // 
            // Font_DrawString
            // 
            this.Font_DrawString.Index = 9;
            this.Font_DrawString.Text = "使用GDI+绘制文本";
            this.Font_DrawString.Click += new System.EventHandler(this.Font_DrawString_Click);
            // 
            // Font_MeasureString
            // 
            this.Font_MeasureString.Index = 10;
            this.Font_MeasureString.Text = "测量文本";
            this.Font_MeasureString.Click += new System.EventHandler(this.Font_MeasureString_Click);
            // 
            // Font_MeasureString2
            // 
            this.Font_MeasureString2.Index = 11;
            this.Font_MeasureString2.Text = "计算指定区域中能够显示的字符总数及行数";
            this.Font_MeasureString2.Click += new System.EventHandler(this.Font_MeasureString2_Click);
            // 
            // Font_ColumnTextOut
            // 
            this.Font_ColumnTextOut.Index = 12;
            this.Font_ColumnTextOut.Text = "实现文件的分栏显示";
            this.Font_ColumnTextOut.Click += new System.EventHandler(this.Font_ColumnTextOut_Click);
            // 
            // Font_StirngTrimming
            // 
            this.Font_StirngTrimming.Index = 13;
            this.Font_StirngTrimming.Text = "字符串的去尾";
            this.Font_StirngTrimming.Click += new System.EventHandler(this.Font_StirngTrimming_Click);
            // 
            // Font_TextOutClip
            // 
            this.Font_TextOutClip.Index = 14;
            this.Font_TextOutClip.Text = "文本输出的剪裁修正";
            this.Font_TextOutClip.Click += new System.EventHandler(this.Font_TextOutClip_Click);
            // 
            // Font_MeasureCharacterRanges
            // 
            this.Font_MeasureCharacterRanges.Index = 15;
            this.Font_MeasureCharacterRanges.Text = "测量文本的局部输出区域";
            this.Font_MeasureCharacterRanges.Click += new System.EventHandler(this.Font_MeasureCharacterRanges_Click);
            // 
            // Font_TextoutDirection
            // 
            this.Font_TextoutDirection.Index = 16;
            this.Font_TextoutDirection.Text = "控制文本输出方向";
            this.Font_TextoutDirection.Click += new System.EventHandler(this.Font_TextoutDirection_Click);
            // 
            // Font_TextAlignment
            // 
            this.Font_TextAlignment.Index = 17;
            this.Font_TextAlignment.Text = "设置文本对齐方式";
            this.Font_TextAlignment.Click += new System.EventHandler(this.Font_TextAlignment_Click);
            // 
            // Font_TextAlignment2
            // 
            this.Font_TextAlignment2.Index = 18;
            this.Font_TextAlignment2.Text = "设置文本对齐方式(2)";
            this.Font_TextAlignment2.Click += new System.EventHandler(this.Font_TextAlignment2_Click);
            // 
            // Font_TextoutUsingTabs
            // 
            this.Font_TextoutUsingTabs.Index = 19;
            this.Font_TextoutUsingTabs.Text = "设置和获取制表符信息";
            this.Font_TextoutUsingTabs.Click += new System.EventHandler(this.Font_TextoutUsingTabs_Click);
            // 
            // Font_UsingTabs
            // 
            this.Font_UsingTabs.Index = 20;
            this.Font_UsingTabs.Text = "使用制表位进行表格输出";
            this.Font_UsingTabs.Click += new System.EventHandler(this.Font_UsingTabs_Click);
            // 
            // Font_TextoutHotkeyPrefix
            // 
            this.Font_TextoutHotkeyPrefix.Index = 21;
            this.Font_TextoutHotkeyPrefix.Text = "快捷键前导字符显示";
            this.Font_TextoutHotkeyPrefix.Click += new System.EventHandler(this.Font_TextoutHotkeyPrefix_Click);
            // 
            // Font_TextoutShadow
            // 
            this.Font_TextoutShadow.Index = 22;
            this.Font_TextoutShadow.Text = "阴影字特效";
            this.Font_TextoutShadow.Click += new System.EventHandler(this.Font_TextoutShadow_Click);
            // 
            // Font_TextoutHashline
            // 
            this.Font_TextoutHashline.Index = 23;
            this.Font_TextoutHashline.Text = "使用影线画刷绘制文本";
            this.Font_TextoutHashline.Click += new System.EventHandler(this.Font_TextoutHashline_Click);
            // 
            // Font_TextoutTexture
            // 
            this.Font_TextoutTexture.Index = 24;
            this.Font_TextoutTexture.Text = "绘制纹理字";
            this.Font_TextoutTexture.Click += new System.EventHandler(this.Font_TextoutTexture_Click);
            // 
            // Font_TextoutGradient
            // 
            this.Font_TextoutGradient.Index = 25;
            this.Font_TextoutGradient.Text = "使用渐变画刷绘制文本";
            this.Font_TextoutGradient.Click += new System.EventHandler(this.Font_TextoutGradient_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 3;
            this.menuItem9.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Path_Construct,
            this.Path_AddLines,
            this.Path_CloseFigure,
            this.Path_FillPath,
            this.Path_AddSubPath,
            this.Path_GetSubPath,
            this.Path_GetPoints,
            this.Path_PathData,
            this.Path_ViewPointFLAG,
            this.Path_SubPathRange,
            this.Path＿Flatten,
            this.Path_Warp,
            this.Path_Transform,
            this.Path_Widen,
            this.Path_WidenDemo,
            this.Region＿FromPath,
            this.Region_Calculate,
            this.Region_GetRects});
            this.menuItem9.Text = "路径和区域";
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // Path_Construct
            // 
            this.Path_Construct.Index = 0;
            this.Path_Construct.Text = "构造路径";
            this.Path_Construct.Click += new System.EventHandler(this.Path_Construct_Click);
            // 
            // Path_AddLines
            // 
            this.Path_AddLines.Index = 1;
            this.Path_AddLines.Text = "在路径中添加多条线段";
            this.Path_AddLines.Click += new System.EventHandler(this.Path_AddLines_Click);
            // 
            // Path_CloseFigure
            // 
            this.Path_CloseFigure.Index = 2;
            this.Path_CloseFigure.Text = "封闭图形";
            this.Path_CloseFigure.Click += new System.EventHandler(this.Path_CloseFigure_Click);
            // 
            // Path_FillPath
            // 
            this.Path_FillPath.Index = 3;
            this.Path_FillPath.Text = "路径的填充";
            this.Path_FillPath.Click += new System.EventHandler(this.Path_FillPath_Click);
            // 
            // Path_AddSubPath
            // 
            this.Path_AddSubPath.Index = 4;
            this.Path_AddSubPath.Text = "添加子路径";
            this.Path_AddSubPath.Click += new System.EventHandler(this.Path_AddSubPath_Click);
            // 
            // Path_GetSubPath
            // 
            this.Path_GetSubPath.Index = 5;
            this.Path_GetSubPath.Text = "GraphicsPathIterator的基本使用";
            this.Path_GetSubPath.Click += new System.EventHandler(this.Path_GetSubPath_Click);
            // 
            // Path_GetPoints
            // 
            this.Path_GetPoints.Index = 6;
            this.Path_GetPoints.Text = "访问路径的点信息";
            this.Path_GetPoints.Click += new System.EventHandler(this.Path_GetPoints_Click);
            // 
            // Path_PathData
            // 
            this.Path_PathData.Index = 7;
            this.Path_PathData.Text = "同时获取端点坐标及类型信息";
            this.Path_PathData.Click += new System.EventHandler(this.Path_PathData_Click);
            // 
            // Path_ViewPointFLAG
            // 
            this.Path_ViewPointFLAG.Index = 8;
            this.Path_ViewPointFLAG.Text = "查看路径端点的标记信息";
            this.Path_ViewPointFLAG.Click += new System.EventHandler(this.Path_ViewPointFLAG_Click);
            // 
            // Path_SubPathRange
            // 
            this.Path_SubPathRange.Index = 9;
            this.Path_SubPathRange.Text = "标记路径区间";
            this.Path_SubPathRange.Click += new System.EventHandler(this.Path_SubPathRange_Click);
            // 
            // Path＿Flatten
            // 
            this.Path＿Flatten.Index = 10;
            this.Path＿Flatten.Text = "路径的展平";
            this.Path＿Flatten.Click += new System.EventHandler(this.Path＿Flatten_Click);
            // 
            // Path_Warp
            // 
            this.Path_Warp.Index = 11;
            this.Path_Warp.Text = "路径的扭曲";
            this.Path_Warp.Click += new System.EventHandler(this.Path_Warp_Click);
            // 
            // Path_Transform
            // 
            this.Path_Transform.Index = 12;
            this.Path_Transform.Text = "路径的线性变换";
            this.Path_Transform.Click += new System.EventHandler(this.Path_Transform_Click);
            // 
            // Path_Widen
            // 
            this.Path_Widen.Index = 13;
            this.Path_Widen.Text = "路径的拓宽";
            this.Path_Widen.Click += new System.EventHandler(this.Path_Widen_Click);
            // 
            // Path_WidenDemo
            // 
            this.Path_WidenDemo.Index = 14;
            this.Path_WidenDemo.Text = "路径的拓宽处理原理演示";
            this.Path_WidenDemo.Click += new System.EventHandler(this.Path_WidenDemo_Click);
            // 
            // Region＿FromPath
            // 
            this.Region＿FromPath.Index = 15;
            this.Region＿FromPath.Text = "从路径中创建文本区域";
            this.Region＿FromPath.Click += new System.EventHandler(this.Region＿FromPath_Click);
            // 
            // Region_Calculate
            // 
            this.Region_Calculate.Index = 16;
            this.Region_Calculate.Text = "区域的运算";
            this.Region_Calculate.Click += new System.EventHandler(this.Region_Calculate_Click);
            // 
            // Region_GetRects
            // 
            this.Region_GetRects.Index = 17;
            this.Region_GetRects.Text = "获取区域的组成矩形集";
            this.Region_GetRects.Click += new System.EventHandler(this.Region_GetRects_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 4;
            this.menuItem11.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Transform,
            this.TranslateTransform,
            this.RotateTransform,
            this.DrawWatch,
            this.ScaleTransform,
            this.RectScale,
            this.FontRotate,
            this.Matrix_ListElements,
            this.MatrixPos,
            this.Martrix_Invert,
            this.Matrix_Multiply,
            this.Matrix_TransformPoints,
            this.Matrix_TransformPoints2,
            this.Matrix_TransformVectors,
            this.Matrix_RotateAt,
            this.Matrix_Shear,
            this.Matrix_TextoutShear,
            this.Matrix_ChangeFontHeight});
            this.menuItem11.Text = "GDI+的坐标变换";
            // 
            // Transform
            // 
            this.Transform.Index = 0;
            this.Transform.Text = "在GDI+使用坐标变换";
            this.Transform.Click += new System.EventHandler(this.Transform_Click);
            // 
            // TranslateTransform
            // 
            this.TranslateTransform.Index = 1;
            this.TranslateTransform.Text = "平移变换的实现";
            this.TranslateTransform.Click += new System.EventHandler(this.TranslateTransform_Click);
            // 
            // RotateTransform
            // 
            this.RotateTransform.Index = 2;
            this.RotateTransform.Text = "旋转图片";
            this.RotateTransform.Click += new System.EventHandler(this.RotateTransform_Click);
            // 
            // DrawWatch
            // 
            this.DrawWatch.Index = 3;
            this.DrawWatch.Text = "汽车里程表的绘制";
            this.DrawWatch.Click += new System.EventHandler(this.DrawWatch_Click);
            // 
            // ScaleTransform
            // 
            this.ScaleTransform.Index = 4;
            this.ScaleTransform.Text = "缩放变换的使用";
            this.ScaleTransform.Click += new System.EventHandler(this.ScaleTransform_Click);
            // 
            // RectScale
            // 
            this.RectScale.Index = 5;
            this.RectScale.Text = "矩形对象的缩放";
            this.RectScale.Click += new System.EventHandler(this.RectScale_Click);
            // 
            // FontRotate
            // 
            this.FontRotate.Index = 6;
            this.FontRotate.Text = "在GDI+中旋转输出文本";
            this.FontRotate.Click += new System.EventHandler(this.FontRotate_Click);
            // 
            // Matrix_ListElements
            // 
            this.Matrix_ListElements.Index = 7;
            this.Matrix_ListElements.Text = "查看矩阵的组成元素";
            this.Matrix_ListElements.Click += new System.EventHandler(this.Matrix_ListElements_Click_1);
            // 
            // MatrixPos
            // 
            this.MatrixPos.Index = 8;
            this.MatrixPos.Text = "使用矩阵的前置与后缀";
            this.MatrixPos.Click += new System.EventHandler(this.MatrixPos_Click);
            // 
            // Martrix_Invert
            // 
            this.Martrix_Invert.Index = 9;
            this.Martrix_Invert.Text = "逆矩阵在变换中的运用";
            this.Martrix_Invert.Click += new System.EventHandler(this.Martrix_Invert_Click);
            // 
            // Matrix_Multiply
            // 
            this.Matrix_Multiply.Index = 10;
            this.Matrix_Multiply.Text = "使用复合变换";
            this.Matrix_Multiply.Click += new System.EventHandler(this.Matrix_Multiply_Click);
            // 
            // Matrix_TransformPoints
            // 
            this.Matrix_TransformPoints.Index = 11;
            this.Matrix_TransformPoints.Text = "使用矩阵批量修改点信息\r\n \r\n";
            this.Matrix_TransformPoints.Click += new System.EventHandler(this.Matrix_TransformPoints_Click);
            // 
            // Matrix_TransformPoints2
            // 
            this.Matrix_TransformPoints2.Index = 12;
            this.Matrix_TransformPoints2.Text = "使用TransformPoints函数实现路径的变换\r\n \r\n";
            this.Matrix_TransformPoints2.Click += new System.EventHandler(this.Matrix_TransformPoints2_Click);
            // 
            // Matrix_TransformVectors
            // 
            this.Matrix_TransformVectors.Index = 13;
            this.Matrix_TransformVectors.Text = "普通矩阵运算与二维向量的矩阵运算";
            this.Matrix_TransformVectors.Click += new System.EventHandler(this.Matrix_TransformVectors_Click);
            // 
            // Matrix_RotateAt
            // 
            this.Matrix_RotateAt.Index = 14;
            this.Matrix_RotateAt.Text = "使用RotateAt函数";
            this.Matrix_RotateAt.Click += new System.EventHandler(this.Matrix_RotateAt_Click);
            // 
            // Matrix_Shear
            // 
            this.Matrix_Shear.Index = 15;
            this.Matrix_Shear.Text = "使用不同的投射变换显示图片";
            this.Matrix_Shear.Click += new System.EventHandler(this.Matrix_Shear_Click);
            // 
            // Matrix_TextoutShear
            // 
            this.Matrix_TextoutShear.Index = 16;
            this.Matrix_TextoutShear.Text = "投影字的特效输出";
            this.Matrix_TextoutShear.Click += new System.EventHandler(this.Matrix_TextoutShear_Click);
            // 
            // Matrix_ChangeFontHeight
            // 
            this.Matrix_ChangeFontHeight.Index = 17;
            this.Matrix_ChangeFontHeight.Text = "文字大小渐变输出特效";
            this.Matrix_ChangeFontHeight.Click += new System.EventHandler(this.Matrix_ChangeFontHeight_Click);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 5;
            this.menuItem12.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ColorMatrix＿Start,
            this.TranslateColor,
            this.ScaleColor,
            this.RotateColor,
            this.ColorShear,
            this.ColorRemap,
            this.SetRGBOutputChannel});
            this.menuItem12.Text = "GDI+的色彩变换";
            // 
            // ColorMatrix＿Start
            // 
            this.ColorMatrix＿Start.Index = 0;
            this.ColorMatrix＿Start.Text = "启用色彩变换矩阵";
            this.ColorMatrix＿Start.Click += new System.EventHandler(this.ColorMatrix＿Start_Click);
            // 
            // TranslateColor
            // 
            this.TranslateColor.Index = 1;
            this.TranslateColor.Text = "色彩平移运算";
            this.TranslateColor.Click += new System.EventHandler(this.TranslateColor_Click);
            // 
            // ScaleColor
            // 
            this.ScaleColor.Index = 2;
            this.ScaleColor.Text = "色彩的缩放运算";
            this.ScaleColor.Click += new System.EventHandler(this.ScaleColor_Click);
            // 
            // RotateColor
            // 
            this.RotateColor.Index = 3;
            this.RotateColor.Text = "色彩的三种旋转方式";
            this.RotateColor.Click += new System.EventHandler(this.RotateColor_Click);
            // 
            // ColorShear
            // 
            this.ColorShear.Index = 4;
            this.ColorShear.Text = "色彩的投射变换";
            this.ColorShear.Click += new System.EventHandler(this.ColorShear_Click);
            // 
            // ColorRemap
            // 
            this.ColorRemap.Index = 5;
            this.ColorRemap.Text = "色彩映射的程序实现";
            this.ColorRemap.Click += new System.EventHandler(this.ColorRemap_Click);
            // 
            // SetRGBOutputChannel
            // 
            this.SetRGBOutputChannel.Index = 6;
            this.SetRGBOutputChannel.Text = "使用色彩变换矩阵实现色彩输出通道";
            this.SetRGBOutputChannel.Click += new System.EventHandler(this.SetRGBOutputChannel_Click);
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 6;
            this.menuItem13.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Metafile,
            this.CroppingAndScaling,
            this.UsingInterpolationMode,
            this.RotateFlip,
            this.ImageSkewing,
            this.Cubeimage,
            this.ThumbnailImage,
            this.Clone,
            this.Picturescale});
            this.menuItem13.Text = "图像的基本处理";
            // 
            // Metafile
            // 
            this.Metafile.Index = 0;
            this.Metafile.Text = "图元文件中的记录与回放";
            this.Metafile.Click += new System.EventHandler(this.Metafile_Click);
            // 
            // CroppingAndScaling
            // 
            this.CroppingAndScaling.Index = 1;
            this.CroppingAndScaling.Text = "图形的剪裁与缩放";
            this.CroppingAndScaling.Click += new System.EventHandler(this.CroppingAndScaling_Click);
            // 
            // UsingInterpolationMode
            // 
            this.UsingInterpolationMode.Index = 2;
            this.UsingInterpolationMode.Text = "使用不同的插值模式控制图形缩放质量";
            this.UsingInterpolationMode.Click += new System.EventHandler(this.UsingInterpolationMode_Click);
            // 
            // RotateFlip
            // 
            this.RotateFlip.Index = 3;
            this.RotateFlip.Text = "绘制镜像图片示例";
            this.RotateFlip.Click += new System.EventHandler(this.RotateFlip_Click);
            // 
            // ImageSkewing
            // 
            this.ImageSkewing.Index = 4;
            this.ImageSkewing.Text = "绘制映射图片";
            this.ImageSkewing.Click += new System.EventHandler(this.ImageSkewing_Click);
            // 
            // Cubeimage
            // 
            this.Cubeimage.Index = 5;
            this.Cubeimage.Text = "立方体贴图";
            this.Cubeimage.Click += new System.EventHandler(this.Cubeimage_Click);
            // 
            // ThumbnailImage
            // 
            this.ThumbnailImage.Index = 6;
            this.ThumbnailImage.Text = "GDI+中处理缩略图";
            this.ThumbnailImage.Click += new System.EventHandler(this.ThumbnailImage_Click);
            // 
            // Clone
            // 
            this.Clone.Index = 7;
            this.Clone.Text = "分块显示图片";
            this.Clone.Click += new System.EventHandler(this.Clone_Click);
            // 
            // Picturescale
            // 
            this.Picturescale.Index = 8;
            this.Picturescale.Text = "图片局部放大(缩小)显示";
            this.Picturescale.Click += new System.EventHandler(this.Picturescale_Click);
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 7;
            this.menuItem15.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ImageAttributesSetNoOp,
            this.SetColorMatrices,
            this.SetOutputChannelColorProfile,
            this.Gammaadjust,
            this.SetOutputChannel,
            this.Colorkey,
            this.Setthreshold,
            this.AdjustedPalette,
            this.SetWrapMode});
            this.menuItem15.Text = "图像色彩信息的调整";
            // 
            // ImageAttributesSetNoOp
            // 
            this.ImageAttributesSetNoOp.Index = 0;
            this.ImageAttributesSetNoOp.Text = "色彩校正的启用与禁用";
            this.ImageAttributesSetNoOp.Click += new System.EventHandler(this.ImageAttributesSetNoOp_Click);
            // 
            // SetColorMatrices
            // 
            this.SetColorMatrices.Index = 1;
            this.SetColorMatrices.Text = "设置不同的色彩调整对象";
            this.SetColorMatrices.Click += new System.EventHandler(this.SetColorMatrices_Click);
            // 
            // SetOutputChannelColorProfile
            // 
            this.SetOutputChannelColorProfile.Index = 2;
            this.SetOutputChannelColorProfile.Text = "使用色彩配置文件进行色彩校正";
            this.SetOutputChannelColorProfile.Click += new System.EventHandler(this.SetOutputChannelColorProfile_Click);
            // 
            // Gammaadjust
            // 
            this.Gammaadjust.Index = 3;
            this.Gammaadjust.Text = "修改Gamma值进行图片输出";
            this.Gammaadjust.Click += new System.EventHandler(this.Gammaadjust_Click);
            // 
            // SetOutputChannel
            // 
            this.SetOutputChannel.Index = 4;
            this.SetOutputChannel.Text = "设置色彩输出通道";
            this.SetOutputChannel.Click += new System.EventHandler(this.SetOutputChannel_Click);
            // 
            // Colorkey
            // 
            this.Colorkey.Index = 5;
            this.Colorkey.Text = "使用关键色";
            this.Colorkey.Click += new System.EventHandler(this.Colorkey_Click);
            // 
            // Setthreshold
            // 
            this.Setthreshold.Index = 6;
            this.Setthreshold.Text = "阈值运用演示程序";
            this.Setthreshold.Click += new System.EventHandler(this.Setthreshold_Click);
            // 
            // AdjustedPalette
            // 
            this.AdjustedPalette.Index = 7;
            this.AdjustedPalette.Text = "获取色彩校正调色板";
            this.AdjustedPalette.Click += new System.EventHandler(this.AdjustedPalette_Click);
            // 
            // SetWrapMode
            // 
            this.SetWrapMode.Index = 8;
            this.SetWrapMode.Text = "设置色彩校正的环绕模式和颜色";
            this.SetWrapMode.Click += new System.EventHandler(this.SetWrapMode_Click);
            // 
            // menuItem16
            // 
            this.menuItem16.Index = 8;
            this.menuItem16.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ListAllImageEncoders,
            this.ListImageEncoder_Detail,
            this.ListImageDecoder,
            this.GetEncoderParameter,
            this.GetAllEncoderParameter,
            this.menuItem17,
            this.SaveBmp2tif,
            this.SaveBMP2JPG,
            this.TransformingJPEG,
            this.MultipleFrameImage,
            this.GetImageFromMultyFrame,
            this.QueryImage,
            this.SetProp});
            this.menuItem16.Text = "图形的编码与解码";
            // 
            // ListAllImageEncoders
            // 
            this.ListAllImageEncoders.Index = 0;
            this.ListAllImageEncoders.Text = "输出编码器信息";
            this.ListAllImageEncoders.Click += new System.EventHandler(this.ListAllImageEncoders_Click);
            // 
            // ListImageEncoder_Detail
            // 
            this.ListImageEncoder_Detail.Index = 1;
            this.ListImageEncoder_Detail.Text = "输出编码器信息";
            this.ListImageEncoder_Detail.Click += new System.EventHandler(this.ListImageEncoder_Detail_Click);
            // 
            // ListImageDecoder
            // 
            this.ListImageDecoder.Index = 2;
            this.ListImageDecoder.Text = "列出系统可用的解码器信息";
            this.ListImageDecoder.Click += new System.EventHandler(this.ListImageDecoder_Click);
            // 
            // GetEncoderParameter
            // 
            this.GetEncoderParameter.Index = 3;
            this.GetEncoderParameter.Text = "查看将位图保存为JPEG时需要设置的参数信息";
            this.GetEncoderParameter.Click += new System.EventHandler(this.GetEncoderParameter_Click);
            // 
            // GetAllEncoderParameter
            // 
            this.GetAllEncoderParameter.Index = 4;
            this.GetAllEncoderParameter.Text = "查看所有的编码信息所需的参数列表";
            this.GetAllEncoderParameter.Click += new System.EventHandler(this.GetAllEncoderParameter_Click);
            // 
            // menuItem17
            // 
            this.menuItem17.Index = 5;
            this.menuItem17.Text = "将BMP文件另存为PNG格式的文件";
            this.menuItem17.Click += new System.EventHandler(this.menuItem17_Click);
            // 
            // SaveBmp2tif
            // 
            this.SaveBmp2tif.Index = 6;
            this.SaveBmp2tif.Text = "将BMP文件保存为TIF文件";
            this.SaveBmp2tif.Click += new System.EventHandler(this.SaveBmp2tif_Click);
            // 
            // SaveBMP2JPG
            // 
            this.SaveBMP2JPG.Index = 7;
            this.SaveBMP2JPG.Text = "使用不同的压缩质量保存JPEG文件";
            this.SaveBMP2JPG.Click += new System.EventHandler(this.SaveBMP2JPG_Click);
            // 
            // TransformingJPEG
            // 
            this.TransformingJPEG.Index = 8;
            this.TransformingJPEG.Text = "JPEG文件的保存与变换";
            this.TransformingJPEG.Click += new System.EventHandler(this.TransformingJPEG_Click);
            // 
            // MultipleFrameImage
            // 
            this.MultipleFrameImage.Index = 9;
            this.MultipleFrameImage.Text = "保存多帧图片";
            this.MultipleFrameImage.Click += new System.EventHandler(this.MultipleFrameImage_Click);
            // 
            // GetImageFromMultyFrame
            // 
            this.GetImageFromMultyFrame.Index = 10;
            this.GetImageFromMultyFrame.Text = "读取多帧图片的子图片";
            this.GetImageFromMultyFrame.Click += new System.EventHandler(this.GetImageFromMultyFrame_Click);
            // 
            // QueryImage
            // 
            this.QueryImage.Index = 11;
            this.QueryImage.Text = "获取图像属性列表";
            this.QueryImage.Click += new System.EventHandler(this.QueryImage_Click);
            // 
            // SetProp
            // 
            this.SetProp.Index = 12;
            this.SetProp.Text = "修改图片属性";
            this.SetProp.Click += new System.EventHandler(this.SetProp_Click);
            // 
            // menuItem18
            // 
            this.menuItem18.Index = 9;
            this.menuItem18.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.FadeInOut,
            this.GrayScale,
            this.Inverse,
            this.Emboss,
            this.OnCanvas,
            this.OnWood,
            this.Flashligt,
            this.BlurAndSharpen});
            this.menuItem18.Text = "图形特技处理";
            // 
            // FadeInOut
            // 
            this.FadeInOut.Index = 0;
            this.FadeInOut.Text = "淡入浅出";
            this.FadeInOut.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // GrayScale
            // 
            this.GrayScale.Index = 1;
            this.GrayScale.Text = "灰度处理与还原";
            this.GrayScale.Click += new System.EventHandler(this.GrayScale_Click);
            // 
            // Inverse
            // 
            this.Inverse.Index = 2;
            this.Inverse.Text = "底片(负片)滤镜";
            this.Inverse.Click += new System.EventHandler(this.Inverse_Click);
            // 
            // Emboss
            // 
            this.Emboss.Index = 3;
            this.Emboss.Text = "浮雕及雕刻";
            this.Emboss.Click += new System.EventHandler(this.Emboss_Click);
            // 
            // OnCanvas
            // 
            this.OnCanvas.Index = 4;
            this.OnCanvas.Text = "油画效果的制作";
            this.OnCanvas.Click += new System.EventHandler(this.OnCanvas_Click);
            // 
            // OnWood
            // 
            this.OnWood.Index = 5;
            this.OnWood.Text = "木刻滤镜";
            this.OnWood.Click += new System.EventHandler(this.OnWood_Click);
            // 
            // Flashligt
            // 
            this.Flashligt.Index = 6;
            this.Flashligt.Text = "强光照射滤镜";
            this.Flashligt.Click += new System.EventHandler(this.Flashligt_Click);
            // 
            // BlurAndSharpen
            // 
            this.BlurAndSharpen.Index = 7;
            this.BlurAndSharpen.Text = "柔化与锐化滤镜";
            this.BlurAndSharpen.Click += new System.EventHandler(this.BlurAndSharpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(560, 313);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "GDIPlusDemo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());

        }

        private void menuItem2_Click(object sender, System.EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black);
            Bitmap bitmap = new Bitmap("demo.bmp");
            int iWidth = bitmap.Width;
            int iHeight = bitmap.Height;

            //初始化色彩变换矩阵
            float[][] tem =
		{
			new float[]{0.0f, 0.0f, 0.0f, 0.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 0.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 0.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 1.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 0.0f, 1.0f}
		};

            ColorMatrix colorMatrix = new ColorMatrix(tem);
            ImageAttributes imageAtt = new ImageAttributes();

            //从0到1进行修改色彩变换矩阵主对角线上的数值
            //使三种基准色的饱和度渐增
            for (float i = 0.0f; i <= 1.0f; i += 0.02f)
            {
                colorMatrix.Matrix00 = i;
                colorMatrix.Matrix11 = i;
                colorMatrix.Matrix22 = i;
                colorMatrix.Matrix33 = i;
                //设置色彩校正矩阵
                imageAtt.SetColorMatrix(colorMatrix,
                    ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                //绘制图片
                g.DrawImage(
                    bitmap, new Rectangle(0, 0, iWidth, iHeight),
                    0, 0,
                    iWidth, iHeight,
                    GraphicsUnit.Pixel,
                    imageAtt);
            }

            MessageBox.Show("下面演示淡出效果");

            //从1到0进行修改色彩变换矩阵主对角线上的数值
            //依次减少每种色彩分量
            for (float i = 1.0f; i >= 0.0f; i -= 0.02f)
            {
                colorMatrix.Matrix00 = i;
                colorMatrix.Matrix11 = i;
                colorMatrix.Matrix22 = i;
                colorMatrix.Matrix33 = i;
                //设置色彩校正矩阵
                imageAtt.SetColorMatrix(colorMatrix,
                    ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                //绘制图片
                g.DrawImage(
                    bitmap, new Rectangle(0, 0, iWidth, iHeight),
                    0, 0,
                    iWidth, iHeight,
                    GraphicsUnit.Pixel,
                    imageAtt);
            }
        }


        private void GrayScale_Click(object sender, System.EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            Bitmap image = new Bitmap("head.bmp");
            int Width = image.Width - 1;
            int Height = image.Height - 1;

            //绘制原图
            g.DrawImage(image, 0, 0);
            g.TranslateTransform(image.Width, 0);

            /*image2、image3分别用来保存最大值法
            和加权平均法处理的灰度图像*/
            Bitmap image2 = image.Clone(new Rectangle(0, 0, image.Width,
                image.Height), PixelFormat.DontCare);
            Bitmap image3 = image.Clone(new Rectangle(0, 0, image.Width,
                image.Height), PixelFormat.DontCare);

            Color color;
            //使用平均值进行灰度处理
            for (int i = Width; i >= 0; i--)
                for (int j = Height; j >= 0; j--)
                {
                    color = image.GetPixel(i, j);
                    //求出平均三个色彩分量的平均值
                    int middle = (color.R +
                        color.G + color.B) / 3;
                    Color colorResult = Color.FromArgb(255, middle, middle, middle);
                    image.SetPixel(i, j, colorResult);
                }
            //重新绘制灰度化图
            g.DrawImage(
                image, new Rectangle(0, 0, Width, Height));

            //在新位置显示最大值法进行灰度处理的结果
            g.TranslateTransform(image.Width, 0);
            //使用最大值法进行灰度处理
            for (int i = Width; i >= 0; i--)
            {
                for (int j = Height; j >= 0; j--)
                {
                    color = image2.GetPixel(i, j);
                    int tmp = Math.Max(color.R, color.G);
                    int maxcolor = Math.Max(tmp, color.B);
                    Color colorResult = Color.FromArgb(255, maxcolor, maxcolor, maxcolor);
                    //设置处理后的灰度信息
                    image2.SetPixel(i, j, colorResult);
                }
            }

            //重新绘制灰度化图
            g.DrawImage(
                image2, new Rectangle(0, 0, Width, Height));
            //在第二行绘制图片
            g.ResetTransform();
            g.TranslateTransform(0, image.Height);

            //使用加权平均法进行灰度处理	
            for (int i = Width; i >= 0; i--)
            {
                for (int j = Height; j >= 0; j--)
                {
                    color = image3.GetPixel(i, j);
                    int R = (int)(0.3f * color.R);
                    int G = (int)(0.59f * color.G);
                    int B = (int)(0.11f * color.B);

                    Color colorResult = Color.FromArgb(255, R, G, B);
                    //设置处理后的灰度信息
                    image3.SetPixel(i, j, colorResult);
                }
            }
            //重新绘制灰度化图
            g.DrawImage(
                image3, new Rectangle(0, 0, Width, Height));

            g.TranslateTransform(image.Width, 0);
            //灰度的还原演示，还原使用最大值法处理的灰度图像image2
            for (int i = Width; i > 0; i--)
            {
                for (int j = Height; j > 0; j--)
                {
                    color = image2.GetPixel(i, j);
                    int R = color.R;
                    int G = color.G;
                    int B = color.B;
                    //分别对RGB三种色彩分量进行伪彩色还原

                    //进行红色分量的还原
                    if (R < 127)
                        R = 0;
                    if (R >= 192)
                        R = 255;
                    if (R <= 191 && R >= 128)
                        R = 4 * R - 510;

                    /*进行绿色分量的还原,为了还原后的绿色分量再次参加比较，
                    这里设置一个变量YES表示G是否已经参加了比较*/

                    bool yes;
                    yes = false;
                    if (G <= 191 && G >= 128 && (!yes))
                    {
                        G = 255;
                        yes = true;
                    }
                    if (G >= 192 && (!yes))
                    {
                        G = 1022 - 4 * G;
                        yes = true;
                    }
                    if (G <= 63 && (!yes))
                    {
                        G = 254 - 4 * G;
                        yes = true;
                    }
                    if (G <= 127 && G >= 67 && (!yes))
                        G = 4 * G - 257;

                    //进行蓝色分量的还原
                    if (B <= 63)
                        B = 255;
                    if (B >= 128)
                        B = 0;
                    if (B >= 67 && B <= 127)
                        B = 510 - 4 * B;

                    //还原后的伪彩色
                    Color colorResult = Color.FromArgb(255, R, G, B);
                    //将还原后的RGB信息重新写入位图
                    image2.SetPixel(i, j, colorResult);

                }
            }
            //重新绘制还原后的伪彩色位图
            //重新绘制灰度化图
            g.DrawImage(
                image2, new Rectangle(0, 0, Width, Height));
        }

        private void Inverse_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);
            graphics.ScaleTransform(0.7f, 0.7f);

            Bitmap image = new Bitmap("head.bmp");
            int Width = image.Width;
            int Height = image.Height;

            Color colorTemp, color2;
            Color color;
            //绘制原图
            graphics.DrawImage(
                image, new Rectangle(0, 0, Width, Height));

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    color = image.GetPixel(i, j);
                    //将色彩进行反转，获得底片效果
                    int r = 255 - color.R;
                    int g = 255 - color.G;
                    int b = 255 - color.B;
                    Color colorResult = Color.FromArgb(255, r, g, b);
                    //将还原后的RGB信息重新写入位图
                    image.SetPixel(i, j, colorResult);
                }
                //动态绘制底片滤镜效果图
                graphics.DrawImage(
                    image, new Rectangle(Width, 0, Width, Height));
            }
            //将已经实现了底片效果的位图再反色(恢复到原图)
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    color = image.GetPixel(i, j);
                    int r = 255 - color.R;
                    int g = 255 - color.G;
                    int b = 255 - color.B;
                    Color colorResult = Color.FromArgb(255, r, g, b);
                    //将还原后的RGB信息重新写入位图
                    image.SetPixel(i, j, colorResult);
                }
                //绘制经过两次反色的位图
                graphics.DrawImage(
                    image, new Rectangle(Width * 2, 0, Width, Height));
            }

        }

        private void Emboss_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);
            graphics.ScaleTransform(0.7f, 0.7f);

            Bitmap image = new Bitmap("head.bmp");
            int Width = image.Width;
            int Height = image.Height;

            //image2:进行雕刻处理
            Bitmap image2 = image.Clone(new Rectangle(0, 0, Width, Height), PixelFormat.DontCare);

            //绘制原图
            graphics.DrawImage(
                image, new Rectangle(0, 0, Width, Height));
            Color color, colorTemp, colorLeft;

            //进行图片的浮雕处理
            //依次访问每个像素的RGB值
            for (int i = Width - 1; i > 0; i--)
            {
                for (int j = Height - 1; j > 0; j--)
                {
                    //获取相邻两个像素的R、G、B值
                    color = image.GetPixel(i, j);
                    colorLeft = image.GetPixel(i - 1, j - 1);
                    //计算与左上角像素的RGB分量之差
                    //67：控制图片的最低灰度，128：常量，更改这两个值会得到不同的效果
                    int r = Math.Max(67, Math.Min(255,
                        Math.Abs(color.R - colorLeft.R + 128)));
                    int g = Math.Max(67, Math.Min(255,
                        Math.Abs(color.G - colorLeft.G + 128)));
                    int b = Math.Max(67, Math.Min(255,
                        Math.Abs(color.B - colorLeft.B + 128)));
                    Color colorResult = Color.FromArgb(255, r, g, b);
                    //将计算后的RGB值回写到位图
                    image.SetPixel(i, j, colorResult);
                }

                //绘制浮雕图
                graphics.DrawImage(
                    image, new Rectangle(Width + 10, 0, Width, Height));
            }

            //进行图片的雕刻处理
            for (int i = 0; i < Height - 1; i++)
            {
                for (int j = 0; j < Width - 1; j++)
                {
                    color = image2.GetPixel(j, i);
                    colorLeft = image2.GetPixel(j + 1, i + 1);
                    //计算与右下角像素的分量之差
                    //67：控制图片的最低灰度，128：常量，更改这两个值会得到不同的效果
                    int r = Math.Max(67, Math.Min(255,
                        Math.Abs(color.R - colorLeft.R + 128)));
                    int g = Math.Max(67, Math.Min(255,
                        Math.Abs(color.G - colorLeft.G + 128)));
                    int b = Math.Max(67, Math.Min(255,
                        Math.Abs(color.B - colorLeft.B + 128)));
                    Color colorResult = Color.FromArgb(255, r, g, b);
                    image2.SetPixel(j, i, colorResult);
                }

                //绘制雕刻图
                graphics.DrawImage(
                    image2, new Rectangle(Width * 2 + 20, 0, Width, image.Height));
            }
        }

        private void CreatePenFromBrush_Click(object sender, System.EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            //构造线性渐变画刷
            LinearGradientBrush LineargradientBrush
                = new LinearGradientBrush(new Rectangle(0, 0, 10, 10),
                Color.Blue, Color.Red, LinearGradientMode.BackwardDiagonal);
            //从线性渐变画刷中构造画笔
            Pen pen = new Pen(LineargradientBrush);
            pen.Width = 10;
            //绘制矩形
            g.DrawRectangle(pen, 10, 10, 100, 100);

            //装入纹理图片
            Bitmap image = new Bitmap("butterfly.bmp");
            //构造纹理画刷
            TextureBrush tBrush = new TextureBrush(image);
            //将画刷传入画笔的构造函数
            Pen texturedPen = new Pen(tBrush, 42);

            //设置贝塞尔曲线的起止点及控制点
            Point p1 = new Point(10, 100);
            Point c1 = new Point(100, 10);
            Point c2 = new Point(150, 150);
            Point p2 = new Point(200, 100);
            g.TranslateTransform(130, 0);
            //绘制贝塞尔曲线
            g.DrawBezier(texturedPen, p1, c1, c2, p2);
        }

        //画笔的线形演示
        private void DashStyle_Custom_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Blue, 5);

            //设置文本输出对齐方式及字体
            StringFormat fmt = new StringFormat();
            fmt.Alignment = StringAlignment.Near;
            fmt.LineAlignment = StringAlignment.Center;
            //字体
            Font font = new Font("Arial", 12);
            SolidBrush sBrush = new SolidBrush(Color.Black);
            graphics.TranslateTransform(0, 30);

            int i = 0;
            //分别使用常见的五种线型绘制直线
            for (; i < 5; i++)
            {
                //设置线型
                pen.DashStyle = (DashStyle)i;
                graphics.DrawLine(pen, 10, 30 * i, 260, 30 * i);
                //输出当前线型的名称
                graphics.DrawString(pen.DashStyle.ToString(),
                    font, sBrush, new Point(260, 30 * i), fmt);
            }

            //使用自定义义线型
            float[] dashVals =	{
									5.0f,   // 线长5个像素
									2.0f,   // 间断2个像素
									15.0f,  // 线长15个像素
									4.0f    // 间断4个像素
								};
            pen.DashPattern = dashVals;
            pen.Color = (Color.Red);
            graphics.DrawLine(pen, 10, 30 * i, 260, 30 * i);
            graphics.DrawString(pen.DashStyle.ToString(), font, sBrush, new Point(260, 30 * i), fmt);
        }

        private void Pen_Align_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);


            Pen pen = new Pen(Color.Gray, 1.0f);


            Pen pen2 = new Pen(Color.FromArgb(155, Color.Red), 10);
            int i = 0;
            for (; i < 5; i++)
            {
                pen2.Alignment = (PenAlignment)i;
                graphics.DrawLine(pen2, new Point(0, 10), new Point(60, 10));
                graphics.TranslateTransform(70, 0);

            }

            graphics.ResetTransform();
            graphics.DrawLine(pen, 0, 10, 600, 10);


        }

        private void Pen_Tranform_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //构造一支宽度为5的红色画笔
            Pen pen = new Pen(Color.Red, 3.0f);
            //将画笔从垂直方向扩充6倍，水平方向保持不变
            pen.ScaleTransform(1, 6);
            //使用未经旋转处理的画笔画圆
            graphics.DrawEllipse(pen, 0, 50, 80, 80);
            //60°旋转
            graphics.TranslateTransform(100, 0);
            pen.RotateTransform(60, MatrixOrder.Append);
            graphics.DrawEllipse(pen, 0, 50, 80, 80);
            //120°旋转
            graphics.TranslateTransform(100, 0);
            pen.RotateTransform(60, MatrixOrder.Append);
            graphics.DrawEllipse(pen, 0, 50, 80, 80);
            //180°旋转
            graphics.TranslateTransform(100, 0);
            pen.RotateTransform(60, MatrixOrder.Append);
            graphics.DrawEllipse(pen, 0, 50, 80, 80);
        }
        //线帽演示
        private void Pen_LineCap_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //设置文本输出对齐方式及字体
            StringFormat fmt = new StringFormat();
            fmt.Alignment = StringAlignment.Near;
            fmt.LineAlignment = StringAlignment.Center;
            //字体
            Font font = new Font("Arial", 12);
            SolidBrush sBrush = new SolidBrush(Color.Black);

            //创建宽度为15的画笔
            Pen pen = new Pen(Color.Black, 15);
            //分别使用不同的线帽
            foreach (LineCap lincap in Enum.GetValues(typeof(LineCap)))
            {
                pen.StartCap = lincap;//起点
                pen.EndCap = lincap;//终点

                graphics.DrawLine(pen, 50, 10, 300, 10);
                //输出当前线帽类型（LineCap枚举成员名）
                graphics.DrawString(pen.StartCap.ToString(),
                    font, sBrush, new Point(320, 10), fmt);
                //平移绘图平面
                graphics.TranslateTransform(0, 30);
            }
        }

        //画笔的透明度支持
        private void Pen_TransColor_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //分别构造蓝色、红色画笔
            Pen blue = new Pen(Color.Blue);
            Pen red = new Pen(Color.Red);
            //绘制网线
            int y = 256;
            for (int x = 0; x < 256; x += 5)
            {
                graphics.DrawLine(blue, 0, y, x, 0);
                graphics.DrawLine(red, 256, x, y, 256);
                y -= 5;
                //延时以查看动态效果
                Thread.Sleep(20);
            }
            //使用绿色画笔绘制不同透明度的线条
            //透明度由上到下依次递减
            for (y = 0; y < 256; y++)
            {
                Pen pen = new Pen(Color.FromArgb(y, Color.Green));
                graphics.DrawLine(pen, 0, y, 256, y);
                //延时以便查看动态效果
                Thread.Sleep(20);
            }

            //使用绿色画笔绘制不同透明度的线条
            //透明度由左到右依次递减
            for (int x = 0; x < 256; x++)
            {
                Pen pen = new Pen(Color.FromArgb(x, Color.Blue));
                graphics.DrawLine(pen, x, 100, x, 200);
                //延时以查看动态效果
                Thread.Sleep(20);
            }
        }
        //简单的单色画刷示意
        private void Brush_SolidBrush_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //创建绿色画刷
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            //定义曲线、多边形端点坐标
            PointF point1 = new PointF(100.0f, 100.0f);
            PointF point2 = new PointF(200.0f, 50.0f);
            PointF point3 = new PointF(250.0f, 200.0f);
            PointF point4 = new PointF(50.0f, 150.0f);
            PointF point5 = new PointF(100.0f, 100.0f);
            PointF[] points = new PointF[] { point1, point2, point3, point4 };
            //填充闭合曲线
            graphics.FillClosedCurve(greenBrush, points, FillMode.Alternate, 1.0f);

            //构造多边形(闭合)
            PointF[] poly = new PointF[] { point1, point2, point3, point4, point5 };
            //在另一个位置填充多边形
            graphics.TranslateTransform(300, 0);
            graphics.FillPolygon(greenBrush, poly, FillMode.Alternate);
        }
        //填充正叶曲线
        private void Brush_FillVurve_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //创建绿色画刷
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            int cx, cy;
            //以当前窗口的中心点绘制正叶曲线
            cx = this.Width / 2;
            cy = this.Height / 2;
            //设置"叶"长
            int LeafLength = 80;
            //设置叶片数量=2* LeafNum
            int LeafNum = 5;
            double x, y, x2, y2, r;

            //创建一个图形路径对象，用以容纳正叶曲线的边界线
            GraphicsPath tmpPath = new GraphicsPath(FillMode.Alternate);
            //生成曲线边界数据：角度变化为一周PI*2
            for (float i = 0.0f; i < Math.PI * 2 + 0.1f; i += (float)Math.PI / 180)
            {
                r = (int)Math.Abs(LeafLength * Math.Cos(LeafNum * i));
                x = r * Math.Cos(i);
                y = r * Math.Sin(i);
                x2 = cx + x;
                y2 = cy + y;
                /*将曲线的边界信息存入临时路径,如果想要查看这些信息所构成的区域
                ，可以在此加入graphics.DrawLine(&pen,x2,y2,x2-1,y2-1);*/
                tmpPath.AddLine((int)x2, (int)y2, (int)x2, (int)y2);
            }

            //填充路径
            graphics.FillPath(greenBrush, tmpPath);

            //绘制中心坐标轴
            Pen pen = new Pen(Color.Gray);
            graphics.DrawLine(pen, 0, cy, cx * 2, cy);
            graphics.DrawLine(pen, cx, 0, cx, cy * 2);
        }
        //影线画刷示意
        private void Brush_HatchBrush_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //构造影线画刷的前后色彩
            Color black = Color.Black;
            Color white = Color.White;

            //使用第一种风格的影线画刷
            HatchBrush brush = new HatchBrush(HatchStyle.Horizontal, black, white);
            graphics.FillRectangle(brush, 20, 20, 100, 50);

            //使用第二种风格的影线画刷
            HatchBrush brush1 = new HatchBrush(HatchStyle.Vertical, black, white);
            graphics.FillRectangle(brush1, 120, 20, 100, 50);

            //使用第三种风格的影线画刷
            HatchBrush brush2 = new HatchBrush(HatchStyle.ForwardDiagonal, black, white);
            graphics.FillRectangle(brush2, 220, 20, 100, 50);

            //使用第四种风格的影线画刷
            HatchBrush brush3 = new HatchBrush(HatchStyle.BackwardDiagonal, black, white);
            graphics.FillRectangle(brush3, 320, 20, 100, 50);

            //使用第五种风格的影线画刷
            HatchBrush brush4 = new HatchBrush(HatchStyle.Cross, black, white);
            graphics.FillRectangle(brush4, 420, 20, 100, 50);

            //使用第六种风格的影线画刷
            HatchBrush brush5 = new HatchBrush(HatchStyle.DiagonalCross, black, white);
            graphics.FillRectangle(brush5, 520, 20, 100, 50);
        }
        //列举出所有风格的影线画刷
        private void Brush_EnumAllStyle_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //设定画刷的前景色为黑色，背景色为白色
            Color black = Color.Black;
            Color white = Color.White;

            //预定义填充区域的宽度及高度
            int WIDTH = 140;
            int HEIGHT = 40;

            //设定输出文本所需信息
            SolidBrush redBrush = new SolidBrush(Color.Red);
            Font myFont = new Font("Arial", 10);

            //column_count表明在每一行能够绘制矩形的总数
            int column_count = this.Width / WIDTH;
            int rol = 0;
            int column = 0;

            //在当前窗口使用所有的影线画刷种风格填充矩形
            Pen pen = new Pen(Color.Blue, 1);
            foreach (HatchStyle style in Enum.GetValues(typeof(HatchStyle)))
            {
                //如果一行已经绘制完毕，换行
                if (rol > column_count - 1)
                {
                    column += 2;
                    rol = 0;
                }
                //创建临时画刷
                HatchBrush brush_tmp = new HatchBrush(style, black, white);
                //填充矩形：设置宽度为WIDTH-20的目的是让矩形之间留出间隔
                graphics.FillRectangle(brush_tmp, rol * WIDTH, column * HEIGHT, WIDTH - 20, HEIGHT);
                //绘制矩形边框
                graphics.DrawRectangle(pen, rol * WIDTH, column * HEIGHT, WIDTH - 20, HEIGHT);

                //显示每种画刷风格的枚举名称
                //计算文本输出区域
                RectangleF layoutRect = new RectangleF(rol * WIDTH, (column + 1) * HEIGHT, WIDTH, HEIGHT);
                StringFormat format = new StringFormat();
                //设置文本输出格式：水平、垂直居中
                format.Alignment = StringAlignment.Near;
                format.LineAlignment = StringAlignment.Center;
                //在矩形框中央输出枚举值
                graphics.DrawString(brush_tmp.HatchStyle.ToString(), myFont, redBrush, layoutRect, format);
                rol += 1;
            }
        }
        //设置绘制原点
        private void Brush_SetRenderingOrigin_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //设定画刷的前景色为黑色，背景色为白色
            Color black = Color.Black;
            Color white = Color.White;
            HatchBrush hatchBrush = new HatchBrush(HatchStyle.DarkDownwardDiagonal, black, white);

            //在竖直方向填充8个矩形，使用默认的画刷原点
            for (int i = 0; i < 8; i++)
            {
                graphics.FillRectangle(hatchBrush, 0, i * 50, 100, 50);
            }

            //使用不同的绘制原点进行区域填充
            for (int i = 0; i < 8; i++)
            {
                //设置画刷原点(水平方向递增)
                graphics.RenderingOrigin = new Point(i, 0);
                graphics.FillRectangle(hatchBrush, 100, i * 50, 100, 50);
            }
        }
        //纹理画刷的不同加载方式
        private void Brush_Texture_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Blue, 2);
            SolidBrush brush = new SolidBrush(Color.Black);
            Font myFont = new Font("宋体", 12);

            //定义纹理画刷的不同填充区域
            RectangleF rect1 = new RectangleF(10, 10, 200, 200);
            RectangleF rect2 = new RectangleF(210, 10, 200, 200);
            RectangleF rect3 = new RectangleF(410, 10, 200, 200);

            //装入纹理图片
            Bitmap image = new Bitmap("nemo.bmp");
            //构造纹理画刷1：使用默认的方式
            TextureBrush tBrush = new TextureBrush(image);
            //使用纹理画刷填充圆形区域
            graphics.FillEllipse(tBrush, rect1);
            //绘制圆周
            graphics.DrawEllipse(pen, rect1);
            graphics.DrawString("图片原始大小", myFont, brush, new PointF(40, 220));

            //构造纹理画刷2：只使用给定图片的部分区域
            TextureBrush tBrush2 = new TextureBrush(image, new Rectangle(55, 35, 55, 35));
            graphics.FillEllipse(tBrush2, rect2);
            graphics.DrawEllipse(pen, rect2);
            graphics.DrawString("使用部分截图", myFont, brush, new PointF(240, 220));

            //构造纹理画刷3：将使用图片的画刷进行缩放
            TextureBrush tBrush3 = new TextureBrush(image);
            //对画刷进行50%的缩放
            Matrix mtr = new Matrix(0.5f, 0.0f, 0.0f, 0.5f, 0.0f, 0.0f);
            tBrush3.Transform = mtr;
            graphics.FillEllipse(tBrush3, rect3);
            graphics.DrawEllipse(pen, rect3);
            graphics.DrawString("比例缩小图片", myFont, brush, new PointF(440, 220));
        }

        //使用图片排列方式
        private void Brush_Texture_WrapMode_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Blue, 2);
            SolidBrush brush = new SolidBrush(Color.Black);
            Font myFont = new Font("Arial", 13);

            //装入纹理图片
            Bitmap image = new Bitmap("nemo.bmp");
            //构造纹理画刷
            TextureBrush tBrush = new TextureBrush(image);
            //将画刷进行缩放
            Matrix mtr = new Matrix(0.5f, 0.0f, 0.0f, 0.5f, 0.0f, 0.0f);
            tBrush.Transform = mtr;

            int i = 0;
            //对图片不使用排列方式
            tBrush.WrapMode = WrapMode.Clamp;
            graphics.FillRectangle(tBrush, new Rectangle(i * 150, 0, 150, 150));
            graphics.DrawRectangle(pen, new Rectangle(i * 150, 0, 150, 150));
            graphics.DrawString("Clamp", myFont, brush, new PointF(0, 155));

            i += 1;
            //对图片使用平铺排列方式	
            tBrush.WrapMode = WrapMode.Tile;
            graphics.FillRectangle(tBrush, new Rectangle(i * 150 + 10, 0, 150, 150));
            graphics.DrawRectangle(pen, new Rectangle(i * 150 + 10, 0, 150, 150));
            graphics.DrawString("Tile", myFont, brush, new PointF(170, 155));

            //对图片使用水平翻转排列方式
            i += 1;
            tBrush.WrapMode = WrapMode.TileFlipX;
            graphics.FillRectangle(tBrush, new Rectangle(i * 150 + 20, 0, 150, 150));
            graphics.DrawRectangle(pen, new Rectangle(i * 150 + 20, 0, 150, 150));

            graphics.DrawString("TileFlipX", myFont, brush, new PointF(320, 155));

            //对图片使用垂直翻转排列方式
            tBrush.WrapMode = WrapMode.TileFlipY;
            graphics.FillRectangle(tBrush, new Rectangle(0, 180, 150, 150));
            graphics.DrawRectangle(pen, new Rectangle(0, 180, 150, 150));
            graphics.DrawString("TileFlipY", myFont, brush, new PointF(0, 335));

            //对图片使用水平、垂直同时翻转排列方式
            tBrush.WrapMode = WrapMode.TileFlipXY;
            graphics.FillRectangle(tBrush, new Rectangle(160, 180, 150, 150));
            graphics.DrawRectangle(pen, new Rectangle(160, 180, 150, 150));
            graphics.DrawString("TileFlipXY", myFont, brush, new PointF(170, 335));
        }
        //纹理画刷的变换
        private void Brush_TextureTransform_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //为三种不同的变换方式的画刷定义填充区域
            RectangleF rect1 = new RectangleF(10, 10, 200, 200);
            RectangleF rect2 = new RectangleF(210, 10, 200, 200);
            RectangleF rect3 = new RectangleF(410, 10, 200, 200);

            Pen pen = new Pen(Color.Blue, 2);
            SolidBrush brush = new SolidBrush(Color.Black);
            Font myFont = new Font("宋体", 12);

            //装入纹理图片
            Bitmap image = new Bitmap("nemo.bmp");
            //构造纹理画刷
            TextureBrush tBrush = new TextureBrush(image);

            //将画刷旋转30度
            tBrush.RotateTransform(30);
            graphics.FillEllipse(tBrush, rect1);
            graphics.DrawEllipse(pen, rect1);
            graphics.DrawString("旋转30度", myFont, brush, new PointF(40, 220));

            //重置变换矩阵：恢复到变化前的状态
            tBrush.ResetTransform();
            //将画刷在水平方向上扩大三倍
            tBrush.ScaleTransform(3, 1);
            graphics.FillEllipse(tBrush, rect2);
            graphics.DrawEllipse(pen, rect2);
            graphics.DrawString("横向扩充三倍", myFont, brush, new PointF(240, 220));

            //平移变换
            tBrush.ResetTransform();
            //将画刷在水平方向上平移30个像素
            tBrush.TranslateTransform(30, 0, MatrixOrder.Append);
            graphics.FillEllipse(tBrush, rect3);
            graphics.DrawEllipse(pen, rect3);
            graphics.DrawString("横向平移30个像素", myFont, brush, new PointF(440, 220));
        }
        //查询画刷的变换信息
        private void Brush_GetTextureMatrix_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Matrix matrix = new Matrix();
            float[] elements = new float[6];
            RectangleF rect1 = new RectangleF(10, 10, 200, 200);
            Pen pen = new Pen(Color.Black, 2);
            SolidBrush brush = new SolidBrush(Color.Black);

            Bitmap image = new Bitmap("nemo.bmp");
            TextureBrush tBrush = new TextureBrush(image);
            //进行三种任意变换
            tBrush.RotateTransform(30);
            tBrush.TranslateTransform(5, 3);
            tBrush.ScaleTransform(0.5f, 2.0f);

            //获取目前已经进行的画刷变换
            matrix = tBrush.Transform;
            //从矩形到数组
            elements = matrix.Elements;
            graphics.FillEllipse(tBrush, rect1);
            graphics.DrawEllipse(pen, rect1);

            //输出矩阵的元素
            for (int j = 0; j < 6; ++j)
            {
                MessageBox.Show(elements[j].ToString(), "矩阵元素值");
            }
        }
        //线性渐变画刷程序
        private void Brush_LinearGradientBrush_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //定义一个由红色到蓝色渐变的画刷:水平变换区域的宽度为40
            //竖直方向不进行色彩渐变
            LinearGradientBrush linGrBrush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(40, 0),
                Color.Red,  //起点色彩	
                Color.Blue);  //止点色彩

            //定义一个色彩呈对角线变换的区域，区域大小为40*40
            LinearGradientBrush linGrBrush2 = new LinearGradientBrush(
                new Point(0, 0),
                new Point(40, 40),
                Color.Red,  //起点色彩	
                Color.Blue); //止点色彩	

            //分别演示不同的线性渐变画刷对目标区域的不同填充效果
            graphics.FillRectangle(linGrBrush,
                0, 0, 200, 200);
            graphics.FillRectangle(linGrBrush2,
                240, 0, 200, 200);

            Pen pen = new Pen(Color.Gray, 1);
            //在对角线方向上绘制单个画刷的填充区域
            for (int i = 0; i < 5; i++)
            {
                graphics.DrawRectangle(pen,
                    240 + i * 40, i * 40, 40, 40);
            }

        }
        //控制线性渐变画刷的填充方式
        private void Brush_LinearArrange_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Blue, 2);
            SolidBrush brush = new SolidBrush(Color.Black);
            Font myFont = new Font("Arial", 13);

            //定义一个色彩呈对角线变换的区域，区域大小为40*40
            LinearGradientBrush linGrBrush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(40, 40),
                Color.Red, //起点色彩	
                Color.Blue); //止点色彩	

            int i = 0;
            //对渐变画刷使用平铺排列方式(默认方式)
            linGrBrush.WrapMode = WrapMode.Tile;
            //填充一个大小为160的正方形
            graphics.FillRectangle(linGrBrush, new Rectangle(i * 160, 0, 160, 160));
            graphics.DrawRectangle(pen, new Rectangle(i * 160, 0, 160, 160));
            graphics.DrawString("Tile", myFont, brush, new Point(20, 165));

            //对渐变画刷使用水平翻转排列方式
            i += 1;
            linGrBrush.WrapMode = WrapMode.TileFlipX;
            //重置绘图平面原点
            graphics.RenderingOrigin = new Point(160, 0);
            graphics.FillRectangle(linGrBrush, new Rectangle(i * 160, 0, 160, 160));
            graphics.DrawRectangle(pen, new Rectangle(i * 160, 160, 0, 160));
            graphics.DrawString("TileFlipX", myFont, brush, new Point(170, 165));

            //对渐变画刷使用垂直翻转排列方式
            linGrBrush.WrapMode = WrapMode.TileFlipY;
            //重置绘图平面原点
            graphics.RenderingOrigin = new Point(0, 200);
            graphics.FillRectangle(linGrBrush, new Rectangle(0, 200, 160, 160));
            graphics.DrawRectangle(pen, new Rectangle(0, 200, 200, 160));
            graphics.DrawString("TileFlipY", myFont, brush, new Point(0, 375));

            //对渐变画刷使用水平、垂直同时翻转排列方式
            linGrBrush.WrapMode = WrapMode.TileFlipXY;
            graphics.RenderingOrigin = new Point(160, 200);
            graphics.FillRectangle(linGrBrush, new Rectangle(160, 200, 160, 160));
            graphics.DrawRectangle(pen, new Rectangle(160, 200, 160, 160));
            graphics.DrawString("TileFlipXY", myFont, brush, new Point(170, 375));

            //标注渐变画刷渐变区域的大小：画格子
            Pen pen2 = new Pen(Color.Gray, 1);
            for (i = 0; i < 8; i++)
                graphics.DrawLine(pen2, 0, i * 40, 320, i * 40);
            for (i = 0; i < 9; i++)
                graphics.DrawLine(pen2, i * 40, 0, i * 40, 360);
        }
        //定义线性渐变画刷的渐变模式
        private void Brush_LinearGradientMode_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Blue, 2);
            SolidBrush brush = new SolidBrush(Color.Black);
            Font myFont = new Font("Arial", 12);

            //定义一个水平渐变画刷，大小40*20
            LinearGradientBrush linGrBrush1 = new LinearGradientBrush(
                new Rectangle(0, 0, 40, 20),
                Color.Red,
                Color.Blue, LinearGradientMode.Horizontal);

            //定义一个垂直渐变画刷
            LinearGradientBrush linGrBrush2 = new LinearGradientBrush(
                new Rectangle(0, 0, 40, 20),
                Color.Red,
                Color.Blue, LinearGradientMode.Vertical);

            //从右上到左下的渐变画刷
            LinearGradientBrush linGrBrush3 = new LinearGradientBrush(
                new Rectangle(0, 0, 40, 20),
                Color.Red,
                Color.Blue, LinearGradientMode.ForwardDiagonal);

            //从左上到左下的渐变画刷
            LinearGradientBrush linGrBrush4 = new LinearGradientBrush(
                new Rectangle(0, 0, 40, 20),
                Color.Red,
                Color.Blue, LinearGradientMode.BackwardDiagonal);

            int i = 0;
            //使用水平渐变的画刷填充区域
            graphics.FillRectangle(linGrBrush1, new Rectangle(i * 160, 0, 160, 160));
            graphics.DrawRectangle(pen, new Rectangle(i * 160, 0, 160, 160));
            graphics.DrawString("水平渐变", myFont, brush, new PointF(20, 165));

            i += 1;
            //重置绘图平面原点
            graphics.RenderingOrigin = new Point(160, 0);
            //使用垂直渐变的画刷填充区域
            graphics.FillRectangle(linGrBrush2, new Rectangle(i * 160, 0, 160, 160));
            graphics.DrawRectangle(pen, new Rectangle(i * 160, 160, 0, 160));
            graphics.DrawString("垂直渐变", myFont, brush, new PointF(170, 165));

            //重置绘图平面原点
            graphics.RenderingOrigin = new Point(0, 200);
            //使用从右上到左下渐变的画刷填充区域
            graphics.FillRectangle(linGrBrush3, new Rectangle(0, 200, 160, 160));
            graphics.DrawRectangle(pen, new Rectangle(0, 200, 200, 160));
            graphics.DrawString("左上->右下", myFont, brush, new PointF(0, 375));

            graphics.RenderingOrigin = new Point(160, 200);
            graphics.FillRectangle(linGrBrush4, new Rectangle(160, 200, 160, 160));
            //使用从左上到右下渐变的画刷填充区域
            graphics.DrawRectangle(pen, new Rectangle(160, 200, 160, 160));
            graphics.DrawString("右上->左下", myFont, brush, new PointF(170, 375));

            //在不同的区域中标注定义渐变方向的矩形
            Pen pen2 = new Pen(Color.Gray, 1);
            for (i = 0; i < 18; i++)
                graphics.DrawLine(pen2, 0, i * 20, 320, i * 20);
            for (i = 0; i < 9; i++)
                graphics.DrawLine(pen2, i * 40, 0, i * 40, 360);
        }
        //渐变线偏转角度
        private void Brush_LinearAngle_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Blue, 2);
            SolidBrush brush = new SolidBrush(Color.Black);
            Font myFont = new Font("Arial", 12);

            //定义一个渐变线偏转角度为30度的渐变画刷，大小40*20
            LinearGradientBrush linGrBrush1 = new LinearGradientBrush(
                new Rectangle(0, 0, 40, 20),
                Color.Red,
                Color.Blue, 30.0f);
            //定义一个渐变线偏转角度为45度的渐变画刷
            LinearGradientBrush linGrBrush2 = new LinearGradientBrush(
                new Rectangle(0, 0, 40, 20),
                Color.Red,
                Color.Blue, 45.0f);
            //定义一个渐变线偏转角度为90度的渐变画刷
            LinearGradientBrush linGrBrush3 = new LinearGradientBrush(
                new Rectangle(0, 0, 40, 20),
                Color.Red,
                Color.Blue, 90.0f);
            //定义一个渐变线偏转角度为180度的渐变画刷
            LinearGradientBrush linGrBrush4 = new LinearGradientBrush(
                new Rectangle(0, 0, 40, 20),
                Color.Red,
                Color.Blue, 180.0f);

            int i = 0;
            //使用偏转角度为30度的渐变画刷填充区域
            graphics.FillRectangle(linGrBrush1, new Rectangle(i * 160, 0, 160, 160));
            graphics.DrawRectangle(pen, new Rectangle(i * 160, 0, 160, 160));
            graphics.DrawString("30度偏转", myFont, brush, new PointF(20, 165));

            i += 1;
            //重置绘图平面原点
            graphics.RenderingOrigin = new Point(160, 0);
            //使用偏转角度为45度的渐变画刷填充区域
            graphics.FillRectangle(linGrBrush2, new Rectangle(i * 160, 0, 160, 160));
            graphics.DrawRectangle(pen, new Rectangle(i * 160, 160, 0, 160));
            graphics.DrawString("45度偏转", myFont, brush, new PointF(170, 165));

            //重置绘图平面原点
            graphics.RenderingOrigin = new Point(0, 200);
            //使用偏转角度为90度的渐变画刷填充区域
            graphics.FillRectangle(linGrBrush3, new Rectangle(0, 200, 160, 160));
            graphics.DrawRectangle(pen, new Rectangle(0, 200, 200, 160));
            graphics.DrawString("90度偏转", myFont, brush, new PointF(0, 375));

            graphics.RenderingOrigin = new Point(160, 200);
            graphics.FillRectangle(linGrBrush4, new Rectangle(160, 200, 160, 160));
            //使用偏转角度为180度的渐变画刷填充区域
            graphics.DrawRectangle(pen, new Rectangle(160, 200, 160, 160));
            graphics.DrawString("180度偏转", myFont, brush, new PointF(170, 375));

            //在不同的区域中标注定义渐变方向的矩形
            Pen pen2 = new Pen(Color.Gray, 1);
            for (i = 0; i < 18; i++)
                graphics.DrawLine(pen2, 0, i * 20, 320, i * 20);
            for (i = 0; i < 9; i++)
                graphics.DrawLine(pen2, i * 40, 0, i * 40, 360);
        }
        //多色渐变画刷
        private void Brush_LinearInterpolation_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //定义三种参与渐变的色彩
            Color[] colors = 
	{
		Color.Red,   // 红色
		Color.Green,//过渡色为绿色
		Color.Blue // 蓝色
	};

            float[] positions = 
	{
		0.0f,   // 由红色起
		0.3f,   // 绿色始于画刷长度的三分之一
		1.0f   // 到蓝色止
	};

            //定义ColorBlend对象
            ColorBlend clrBlend = new ColorBlend(3);
            clrBlend.Colors = colors;
            clrBlend.Positions = positions;

            //构造一条从黑色到白色的渐变画刷
            LinearGradientBrush linGrBrush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(180, 0),
                Color.Black, Color.White);

            //设置渐变画刷的多色渐变信息
            linGrBrush.InterpolationColors = clrBlend;
            //使用多色渐变画刷填充目标区域
            graphics.FillRectangle(linGrBrush, 0, 0, 180, 100);

            //使用普通的方法实现多色渐变
            //由红到绿，长度60
            LinearGradientBrush linGrBrush1 = new LinearGradientBrush(
                new Point(0, 0),
                new Point(60, 0),
                Color.Red,
                Color.Green);
            //由绿到蓝，长度120
            LinearGradientBrush linGrBrush2 = new LinearGradientBrush(
                new Point(60, 0),
                new Point(181, 0),
                Color.Green,
                Color.Blue);
            //分别使用两个画刷填充两个相邻区域，形成多色渐变
            graphics.FillRectangle(linGrBrush1, 0, 120, 60, 100);
            graphics.FillRectangle(linGrBrush2, 60, 120, 120, 100);
        }
        //自定义渐变过程：三角形
        private void Brush_LinearCustomize_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush brush = new SolidBrush(Color.Black);
            Font myFont = new Font("宋体", 12);
            //定义一个双色渐变画刷
            LinearGradientBrush linGrBrush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(250, 0),
                Color.Red,
                Color.Blue);

            //绘制两条使用默认渐变方式填充的矩形，以用作比较
            graphics.FillRectangle(linGrBrush, 0, 0, 250, 15);
            graphics.FillRectangle(linGrBrush, 500, 0, 250, 15);

            //依次改变合成点位置
            int row = 1;
            for (float i = 0.0f; i < 1.0f; i += 0.1f)
            {
                linGrBrush.SetBlendTriangularShape(i);
                graphics.FillRectangle(linGrBrush, 0, row * 15, 250, 15);
                row++;
            }
            graphics.DrawString("改变合成点位置",
                myFont, brush, new PointF(40, 200));

            //依次改变彩色合成因子
            row = 1;
            for (float i = 0.0f; i < 1.0f; i += 0.1f)
            {
                //将合成的相对位置设置在整个区域的50%处
                linGrBrush.SetBlendTriangularShape(0.5f, i);
                graphics.FillRectangle(linGrBrush, 500, row * 15, 250, 15);
                row++;
            }
            graphics.DrawString("改变色彩合成因子",
                myFont, brush, new PointF(540, 200));

        }
        //基于钟形曲线的渐变画刷		
        private void Brush_LinearGradientBrush_BellShape_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Rectangle myRect = new Rectangle(10, 10, 150, 75);
            //定义线性渐变画刷
            LinearGradientBrush myLGBrush = new LinearGradientBrush(
                myRect, Color.Blue, Color.Red, 0.0f, true);

            //使用默认的线性渐变画刷填充椭圆
            graphics.FillEllipse(myLGBrush, myRect);

            //将渐变过程设置成基于钟形曲线的渐变
            myLGBrush.SetSigmaBellShape(.5f, 1.0f);

            //使用自定义渐变过程的画刷填充椭圆
            graphics.TranslateTransform(160, 0);
            graphics.FillEllipse(myLGBrush, myRect);
        }

        private void Brush_PathGradientBrush_Star_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Gray, 1);
            SolidBrush pthGrBrush = new SolidBrush(Color.Red);
            SolidBrush blackbrush = new SolidBrush(Color.Blue);
            graphics.TranslateTransform(20, 20);

            //构造五星的10个边的端点坐标
            Point[] points = {
								 new Point(75, 0), new Point(100, 50), 
								 new Point(150, 50), new Point(112, 75),
								 new Point(150, 150), new Point(75, 100), 
								 new Point(0, 150), new Point(37, 75), 
								 new Point(0, 50), new Point(50, 50),
								 new Point(75, 0)
							 };

            // 创建路径
            GraphicsPath path = new GraphicsPath();
            //在路径中加入直线
            path.AddLines(points);
            //填充路径
            graphics.FillPath(pthGrBrush, path);
            //绘制边界
            graphics.DrawLines(pen, points);
            //绘制定义10个边的端点
            for (int i = 0; i < 10; i++)
                //每个圆点的直径为10
                graphics.FillEllipse(blackbrush, points[i].X - 5, points[i].Y - 5, 10, 10);
        }
        //使用路径渐变画刷绘制五星
        private void Brush_PathGradientBrush_Star2_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //构造五星的10个边的端点坐标
            Point[] points = {
								 new Point(75, 0), new Point(100, 50), 
								 new Point(150, 50), new Point(112, 75),
								 new Point(150, 150), new Point(75, 100), 
								 new Point(0, 150), new Point(37, 75), 
								 new Point(0, 50), new Point(50, 50),
								 new Point(75, 0)
							 };
            // 创建路径
            GraphicsPath path = new GraphicsPath();
            //在路径中添加直线
            path.AddLines(points);
            //创建路径渐变画刷
            PathGradientBrush pthGrBrush = new PathGradientBrush(path);
            //设置中心点色彩(终点色)
            pthGrBrush.CenterColor = Color.Red;

            //设置每个端点的色彩(终点色)
            Color[] colors = new Color[] 
			{
				Color.Black, Color.Green,
				Color.Blue, Color.White, 
				Color.Black, Color.Green, 
				Color.Blue, Color.White,
				Color.Black, Color.Green
			};
            //设置路径渐变画刷的边缘色
            pthGrBrush.SurroundColors = colors;
            // 填充目标路径
            graphics.FillPath(pthGrBrush, path);

            //将中心色及边界色都设置成随机色，查看渐变效果
            Random rand = new Random();
            for (int z = 0; z < 10; z++)
            {
                //在水平方向上平移绘图平面
                graphics.TranslateTransform(200.0f, 0.0f);
                //设置中心点色彩为随机色
                pthGrBrush.CenterColor =
                    (Color.FromArgb(rand.Next(255) % 155, rand.Next(255) % 255, rand.Next(255) % 255));
                //使用原有的边缘色
                pthGrBrush.SurroundColors = colors;
                graphics.FillPath(pthGrBrush, path);
            }
        }
        //使用多个路径渐变画刷
        private void Brush_Using_MorePathGradientBrush_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //定义一个六边形，边长为50	
            float fHalf = 50 * (float)Math.Sin(120.0f / 360.0f * Math.PI);
            PointF[] pts = new PointF[] 
		{
			new PointF( 50, 0),           
			new PointF( 50 * 1.5f,  0),
			new PointF( 50,         0),           
			new PointF( 50 / 2,    -fHalf),
			new PointF(-50 / 2,    -fHalf),
			new PointF(-50,         0),
			new PointF(-50 * 1.5f,  0), 
			new PointF(-50,         0),
			new PointF(-50 / 2,     fHalf),     
			new PointF( 50 / 2,     fHalf)
		};

            //构造六边形渐变画刷
            PathGradientBrush pgbrush1 = new PathGradientBrush(pts);

            //在水平和垂直方向上平移六边形的顶点
            for (int i = 0; i < 10; i++)
            {
                pts[i].X += 50 * 1.5f;
                pts[i].Y += fHalf;
            }

            //根据改变坐标后的点重新生成路径渐变画刷
            PathGradientBrush pgbrush2 = new PathGradientBrush(pts);

            //设置路径渐变画刷的翻转方式为平铺
            pgbrush1.WrapMode = WrapMode.Tile;
            pgbrush2.WrapMode = WrapMode.Tile;

            //分别设置两个画刷的中心点色彩为红、绿色
            pgbrush1.CenterColor = Color.Red;
            pgbrush2.CenterColor = Color.Green;

            //填充当前窗口
            graphics.FillRectangle(pgbrush1, 0, 0, this.Width, this.Height);
            //在上次未被填充的区域中再次填充当前窗口的空白部份
            graphics.FillRectangle(pgbrush2, 0, 0, this.Width, this.Height);
        }
        //路径渐变画刷的填充方式
        private void Brush_PathGradientBrush_WrapMode_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Blue, 2);
            SolidBrush brush = new SolidBrush(Color.Black);
            Font myFont = new Font("Arial", 12);

            //定义五星的边线坐标，为演示翻转效果，将五星的一角拉长
            Point[] points = new Point[]
		{
			new Point(75, 0), new Point(100, 50), 
			new Point(150, 50), new Point(112, 75),
			new Point(150, 150), new Point(75, 100), 
			new Point(0, 190), new Point(37, 75), 
			new Point(10, 50), new Point(50, 50)
		};

            GraphicsPath path = new GraphicsPath();
            path.AddLines(points);

            // 构造路径渐变画刷
            PathGradientBrush pthGrBrush = new PathGradientBrush(path);
            //设置中心点色彩(终点色)
            pthGrBrush.CenterColor = Color.Red;

            //设置每个端点的色彩(终点色)
            Color[] colors = new Color[]
		{
			Color.Black,   Color.Green,
			Color.Blue, Color.White, 
			Color.Black,   Color.Green, 
			Color.Blue, Color.White,
			Color.Black,   Color.Green
		};

            pthGrBrush.SurroundColors = colors;
            //缩小画刷
            pthGrBrush.ScaleTransform(0.2f, 0.2f);
            int i = 0;

            //对渐变画刷使用平铺排列方式(默认方式)
            pthGrBrush.WrapMode = WrapMode.Tile;
            graphics.FillRectangle(pthGrBrush, new Rectangle(i * 120, 0, 120, 120));
            graphics.DrawRectangle(pen, new Rectangle(i * 120, 0, 120, 120));
            graphics.DrawString("Tile", myFont, brush, new PointF(20, 125));

            i += 1;
            pthGrBrush.WrapMode = WrapMode.TileFlipX;
            graphics.FillRectangle(pthGrBrush, new Rectangle(i * 120, 0, 120, 120));
            graphics.DrawRectangle(pen, new Rectangle(i * 120, 0, 120, 120));
            graphics.DrawString("TileFlipX", myFont, brush, new PointF(170, 125));

            //对渐变画刷使用垂直翻转排列方式
            pthGrBrush.WrapMode = WrapMode.TileFlipY;
            graphics.FillRectangle(pthGrBrush, new Rectangle(0, 200, 120, 120));
            graphics.DrawRectangle(pen, new Rectangle(0, 200, 120, 120));
            graphics.DrawString("TileFlipY", myFont, brush, new PointF(0, 325));

            //对渐变画刷使用水平、垂直同时翻转排列方式
            pthGrBrush.WrapMode = WrapMode.TileFlipXY;
            graphics.FillRectangle(pthGrBrush, new Rectangle(120, 200, 120, 120));
            graphics.DrawRectangle(pen, new Rectangle(120, 200, 120, 120));
            graphics.DrawString("TileFlipXY", myFont, brush, new PointF(170, 325));

            //输出路径的约束矩形、中心点信息
            RectangleF rect = new RectangleF(); ;
            //获取画刷的约束矩形对象
            rect = pthGrBrush.Rectangle;
            PointF CenterPoint = new PointF(0, 0);
            //获取画刷的中心点信息
            CenterPoint = pthGrBrush.CenterPoint;
            String tmp = new String('S', 256); ;

            //格式化字符串
            tmp = string.Format("当前约束矩形的左上坐标为({0},{1}),宽度={2} 高度={3}",
                rect.X, rect.Y, rect.Height, rect.Width);
            tmp += "\n" + string.Format("当前渐变路径的中心点坐标为({0:F2},{1:F2})",
                CenterPoint.X, CenterPoint.Y);
            //输出中心点及约束矩形对象的信息
            graphics.DrawString(tmp, myFont, brush, new PointF(0, 395));
        }
        //更改路径渐变画刷的中心点
        private void Brush_PathGradientBrush_CenterPoint_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //构造一个圆形区域
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, 200, 200);
            SolidBrush brush = new SolidBrush(Color.FromArgb(155, Color.Red));
            //构造一个圆形路径渐变画刷
            PathGradientBrush pthGrBrush = new PathGradientBrush(path);

            //设置中心点色彩
            pthGrBrush.CenterColor = Color.FromArgb(155, Color.White);
            Color[] colors = new Color[] { Color.FromArgb(55, Color.Blue) };
            //设置边缘色
            pthGrBrush.SurroundColors = colors;
            //填充区域，使用单色画刷
            graphics.FillEllipse(pthGrBrush, 0, 0, 200, 200);
            //获取中心点色彩
            PointF center = new PointF(0, 0);
            center = pthGrBrush.CenterPoint;

            //更改画刷的中心点沿圆周的上半部分平移
            for (int i = 0; i < 200; i++)
            {
                center.X = i;
                center.Y = 10;
                pthGrBrush.CenterPoint = center;
                graphics.FillEllipse(pthGrBrush, 0, 0, 200, 200);
                //标记当前中心点
                graphics.FillEllipse(brush, center.X, center.Y, 2, 2);
            }

            //更改画刷的中心点沿圆周的下半部分平移
            for (int i = 200; i > 0; i--)
            {
                center.X = i;
                center.Y = 190;
                pthGrBrush.CenterPoint = center;
                graphics.FillEllipse(pthGrBrush, 0, 0, 200, 200);
                //标记当前中心点
                graphics.FillEllipse(brush, center.X, center.Y, 2, 2);
            }

        }
        //对路径渐变画刷使用多色渐变
        private void Brush_PathGradientBrush_InterpolationColors_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush brush = new SolidBrush(Color.Red);
            //设置三角形的三个点
            Point[] points = new Point[]
		{
			new Point(100, 0), 
			new Point(200, 200),
			new Point(0, 200)
		};
            //创建一个三角形渐变画刷
            PathGradientBrush pthGrBrush = new PathGradientBrush(points);
            //-定义参与渐变的色彩
            Color[] colors = new Color[] 
		{
			Color.Red,     //红
			Color.Green,     //绿
			Color.Blue // 蓝
		};

            //设置合成点的位置
            float[] pos = new float[] 
		{
			0.0f,    // 红色在区域边界为红色
			0.4f,    //在距离中心40%的位置处使用绿色
			1.0f	//中心点使用蓝色
		};

            //设置渐变的过渡色
            ColorBlend blend = new ColorBlend(3);
            blend.Colors = colors;
            blend.Positions = pos;

            pthGrBrush.InterpolationColors = blend;
            //填充区域
            graphics.FillRectangle(pthGrBrush, 0, 0, 300, 300);
            //标记中心点
            PointF centerpoint = new PointF(0, 0); ;
            centerpoint = pthGrBrush.CenterPoint;
            graphics.FillEllipse(brush, centerpoint.X - 5, centerpoint.Y - 5, 10, 10);
        }
        //更改路径渐变画刷的焦点缩放比例
        private void Brsuh_PathGradietBrush_Focus_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Black, 3);
            SolidBrush brush = new SolidBrush(Color.Black);
            Font myFont = new Font("Arial", 12);

            //指定三角形三点坐标,创建三角形渐变画
            Point[] points = new Point[]
	{
		new Point(100, 0),
		new Point(200, 200), 
		new Point(0, 200)
	};

            PathGradientBrush pthGrBrush = new PathGradientBrush(points);
            //指明渐变色
            Color[] colors = new Color[] { Color.Red, Color.Blue };
            //指明色彩合成位置
            float[] relativePositions = new float[]
		{
			0.0f,    // 红色做边界
			1.0f // 蓝色为中心
		};

            //定义ColorBlend对象
            ColorBlend clrBlend = new ColorBlend();
            clrBlend.Colors = colors;
            clrBlend.Positions = relativePositions;
            //设置渐变色
            pthGrBrush.InterpolationColors = clrBlend;

            //使用默认缩放因子进行填充
            graphics.FillRectangle(pthGrBrush, 0, 0, 200, 200);

            //获取默认缩放因子 
            PointF FocusScales = new PointF(0, 0);
            FocusScales = pthGrBrush.FocusScales;
            //输出缩放信息
            String tmp = new String('D', 256);
            tmp = String.Format("水平:x={0:F2}\n垂直:y={1:F2}", FocusScales.X, FocusScales.Y);
            graphics.DrawString(tmp, myFont, brush, new PointF(0, 210));

            //平移绘图平面
            graphics.TranslateTransform(200, 0);
            //更改缩放因子
            FocusScales.X = 0.6f;
            FocusScales.Y = 0.6f;
            pthGrBrush.FocusScales = FocusScales;

            graphics.FillRectangle(pthGrBrush, 0, 0, 200, 200);
            graphics.DrawString("水平:x=0.6\n垂直:y=0.6",
                myFont, brush, new PointF(0, 210));

            //水平缩放不等于垂直缩放时特例
            graphics.TranslateTransform(200, 0);
            //更改缩放因子
            FocusScales.X = 0.1f;
            FocusScales.Y = 0.8f;
            pthGrBrush.FocusScales = FocusScales;

            graphics.FillRectangle(pthGrBrush, 0, 0, 200, 200);
            graphics.DrawString("水平:x=0.1\n垂直:y=0.8",
                myFont, brush, new PointF(0, 210));

            //水平缩放=垂直缩放=1.0
            graphics.TranslateTransform(200, 0);
            FocusScales.X = 1.0f;
            FocusScales.Y = 1.0f;
            pthGrBrush.FocusScales = FocusScales;

            graphics.FillRectangle(pthGrBrush, 0, 0, 200, 200);
            graphics.DrawString("水平:x=1.0\n垂直:y=1.0",
                myFont, brush, new PointF(0, 210));

            //水平缩放不等于垂直缩放时特例：放大原有区域
            graphics.TranslateTransform(200, 0);
            FocusScales.X = 2.0f;
            FocusScales.Y = 1.5f;
            pthGrBrush.FocusScales = FocusScales;

            graphics.FillRectangle(pthGrBrush, 0, 0, 200, 200);
            graphics.DrawString("水平:x=2.0\n垂直:y=1.5",
                myFont, brush, new PointF(0, 210));

        }
        //路径渐变画刷的变换
        private void Brush_PathGradientBrush_Transform_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            // 定义一个三角形路径渐变画刷
            Point[] pts = new Point[] { new Point(50, 0), new Point(100, 100), new Point(0, 100) };
            PathGradientBrush pthGrBrush = new PathGradientBrush(pts);

            //对画刷使用垂直翻转方式
            pthGrBrush.WrapMode = WrapMode.TileFlipY;
            //缩小画刷	
            pthGrBrush.ScaleTransform(0.5f, 0.5f);
            //填充当前窗口
            graphics.FillRectangle(pthGrBrush, 0, 0, this.Width, this.Height);

            //将画刷旋转90度
            pthGrBrush.RotateTransform(90.0f, MatrixOrder.Append);
            //再次填充当前窗口
            graphics.FillRectangle(pthGrBrush, 0, 0, this.Width, this.Height);
        }

        private void Brsuh_LinearGradientBrush_UsingGamma_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            LinearGradientBrush linGrBrush = new LinearGradientBrush(
                new Point(0, 10),
                new Point(200, 10),
                Color.Red,
                Color.Blue);

            graphics.FillRectangle(linGrBrush, 0, 0, 200, 50);
            linGrBrush.GammaCorrection = true;
            graphics.FillRectangle(linGrBrush, 0, 60, 200, 50);

        }
        //简单的使用字体示意
        private void Font_UsingFontInGDIPlus_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White); ;
            //新建一个字体对话框
            FontDialog dlg = new FontDialog();
            //允许对字体进行色彩设置
            dlg.ShowColor = true;
            //调用字体选择对话框
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            //获取在字体对话框中的字体信息
            Font myFont = dlg.Font;
            //根据字体色彩创建画刷
            SolidBrush brush = new SolidBrush(dlg.Color);
            //设置文本输出格式：在当前窗口中居中显示
            StringFormat fmt = new StringFormat();
            fmt.Alignment = StringAlignment.Center;
            fmt.LineAlignment = StringAlignment.Center;
            //输出文本
            graphics.DrawString("输出文本", myFont, brush, new Rectangle(0, 0, this.Width, this.Height), fmt);

        }
        //枚举所有的字体系列
        private void Font_EnumAllFonts_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush solidBrush = new SolidBrush(Color.Black);
            FontFamily fontFamily = new FontFamily("Arial");
            Font font = new Font(fontFamily, 8, FontStyle.Regular, GraphicsUnit.Point);
            //设置文本输出格式
            StringFormat fmt = new StringFormat();
            fmt.Alignment = StringAlignment.Near;
            fmt.LineAlignment = StringAlignment.Near;

            string tmp = "";
            //获取所有已经安装的字体系列
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();
            FontFamily[] fontfamily = installedFontCollection.Families;
            int index = 0;
            //访问fontfamily数组的每一个成员
            foreach (FontFamily i in fontfamily)
            {
                //获取当前字体系列名称
                tmp += i.Name + ", ";
                index++;
            }

            //在窗口中输出所有的字体系列名
            Rectangle r = new Rectangle(0, 10, this.Width, this.Height);
            graphics.DrawString(tmp, font, solidBrush, r, fmt);
            //输出字体系列信息
            tmp = String.Format("在你的系统中已经安装的字体有{0}种，其名称分别为:\n", index + 1);
            graphics.DrawString(tmp, font, solidBrush, new Point(0, 0));
        }

        //启用增强型选择对话框表单
        private void Font_EnhanceFontDialog_Click(object sender, System.EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }
        //使用不同的字体边缘处理方式
        private void Font_UsingTextRenderHint_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush brs = new SolidBrush(Color.Black);
            FontFamily fontFamily = new FontFamily("Arial");
            Font font = new Font(fontFamily, 60, FontStyle.Regular, GraphicsUnit.Pixel);

            //使用不同的边缘处理方式输出六行文本
            foreach (TextRenderingHint Render in Enum.GetValues(typeof(TextRenderingHint)))
            {
                //设置边缘处理方式
                graphics.TextRenderingHint = Render;
                //输出文本
                graphics.DrawString("Render", font, brs, new PointF(0, 0));
                //绘图平面下移地行
                graphics.TranslateTransform(0, font.Height);
            }
        }
        //使用私有字体集合
        private void Font_Privatefontcollection_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            PointF pointF = new PointF(0.0f, 10.0f);
            SolidBrush solidBrush = new SolidBrush(Color.Red);
            //创建私有字体集
            PrivateFontCollection privateFontCollection = new PrivateFontCollection();

            //在私有字体集中追迷你繁启体字库文件"繁启体.TTF"
            string fontfile = "c:\\繁启体.TTF";
            try
            {
                privateFontCollection.AddFontFile(fontfile);
            }
            catch
            {
                MessageBox.Show("字体文件加载失败", "出错啦！");
                return;
            }

            //从私有字体集合中构造繁启体，大小为35像素
            FontFamily pFontFamily = new FontFamily("迷你繁启体", privateFontCollection);
            Font tmpFont = new Font(pFontFamily, 35);
            //输出繁启体文字
            graphics.DrawString("沉舟侧畔千帆过", tmpFont, solidBrush, pointF);
            //垂直坐标一移一行，行高为  字体的高度
            pointF.Y += tmpFont.Height;
            graphics.DrawString("病树前头万木春", tmpFont, solidBrush, pointF);
        }

        private void menuItem9_Click(object sender, System.EventArgs e)
        {

        }
        //在私有字体集合中使用多种字体
        private void Font_Privatefontcollection2_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            PointF pointF = new PointF(0.0f, 10.0f);
            SolidBrush solidBrush = new SolidBrush(Color.Red);
            //创建私有字体集
            PrivateFontCollection privateFontCollection = new PrivateFontCollection();
            //在私有字体集中追加三个不同的字体文件
            privateFontCollection.AddFontFile("C:\\WINDOWS\\Fonts\\STCAIYUN.TTF");
            privateFontCollection.AddFontFile("C:\\WINDOWS\\Fonts\\SIMLI.TTF");
            privateFontCollection.AddFontFile("C:\\WINDOWS\\Fonts\\Arial.ttf");

            //访问私有字体集合中的所有字体系列
            foreach (FontFamily i in privateFontCollection.Families)
            {
                Font tmpFont = new Font(i, 35);
                //输出繁启体文字
                graphics.DrawString("字体名:  " + i.Name, tmpFont, solidBrush, pointF);
                graphics.TranslateTransform(0, tmpFont.Height);
            }

            //通过访问PrivateFontCollection类的Families数组成员来字体
            for (int index = 0; index < privateFontCollection.Families.Length; index++)
            {
                Font tmpFont = new Font(privateFontCollection.Families[index].Name, 35);
                //输出繁启体文字
                graphics.DrawString("字体名:  " + privateFontCollection.Families[index].Name,
                    tmpFont, solidBrush, pointF);
                graphics.TranslateTransform(0, tmpFont.Height);
            }
        }
        //检查字体风格是否可用
        private void Font_IsStyleAvailable_Click(object sender, System.EventArgs e)
        {

            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Gray);
            PointF pointF = new PointF(10.0f, 0.0f);
            SolidBrush solidBrush = new SolidBrush(Color.Black);
            //信息输出所使用的字体
            Font msgfont = new Font("Arial", 12);

            //创建私有字体集
            PrivateFontCollection privateFontCollection = new PrivateFontCollection();
            //在私有字体集中追加三个字体文件
            //黑体
            privateFontCollection.AddFontFile("C:\\windows\\Fonts\\simhei.ttf");
            //Courier New字体
            privateFontCollection.AddFontFile("C:\\windows\\Fonts\\CourBI.ttf");
            //华文楷体_GB2312
            privateFontCollection.AddFontFile("C:\\windows\\Fonts\\STLITI.ttf");

            string familyName = string.Empty;
            string tmpmsg = string.Empty;

            //查询私有字体集中字体系列数量
            int count = privateFontCollection.Families.Length;
            //获取字体系列数组
            FontFamily[] pFontFamily = new FontFamily[count];
            //将字体系列中的字体名中加入pFontFamily中
            pFontFamily = privateFontCollection.Families;

            /*对私有字体集中每一个字体系列进行五种字体风格
            的查询，如果字体风格可用，使用该风格进行文本绘制
            */
            for (int j = 0; j < count; ++j)
            {
                //从字体系列中获取字体名
                familyName = pFontFamily[j].Name;
                // 常规风格是否可用
                if (pFontFamily[j].IsStyleAvailable(FontStyle.Regular))
                {
                    tmpmsg = "  字体的常规风格可用";
                    //构造字体
                    FontFamily fm = new FontFamily(familyName, privateFontCollection);
                    Font tmpFont = new Font(fm,
                        12, FontStyle.Regular, GraphicsUnit.Pixel);
                    //输出使用常规风格的字体
                    graphics.DrawString(familyName + tmpmsg, tmpFont, solidBrush, pointF);
                    //垂直坐标一移一行，行高为  字体的高度
                    pointF.Y += tmpFont.Height;
                }
                else
                {
                    graphics.DrawString(familyName + tmpmsg +
                        "  字体的常规风格不可用", msgfont, solidBrush, pointF);
                    pointF.Y += msgfont.Height;
                }
                tmpmsg = string.Empty;

                // 粗体风格是否可用
                if (pFontFamily[j].IsStyleAvailable(FontStyle.Bold))
                {
                    tmpmsg = "  字体的粗体风格可用";
                    //构造字体
                    FontFamily fm = new FontFamily(familyName, privateFontCollection);
                    Font tmpFont = new Font(fm,
                        12, FontStyle.Bold, GraphicsUnit.Pixel);
                    //输出使用常规风格的字体
                    graphics.DrawString(familyName + tmpmsg, tmpFont, solidBrush, pointF);
                    //垂直坐标一移一行，行高为  字体的高度
                    pointF.Y += tmpFont.Height;
                }
                else
                {
                    graphics.DrawString(familyName + tmpmsg +
                        "  字体的粗体风格不可用", msgfont, solidBrush, pointF);
                    pointF.Y += msgfont.Height;
                }
                tmpmsg = string.Empty;

                // 斜体风格是否可用
                if (pFontFamily[j].IsStyleAvailable(FontStyle.Italic))
                {
                    tmpmsg = "  字体的斜体风格可用";
                    //构造字体
                    FontFamily fm = new FontFamily(familyName, privateFontCollection);
                    Font tmpFont = new Font(fm,
                        12, FontStyle.Italic, GraphicsUnit.Pixel);
                    //输出使用常规风格的字体
                    graphics.DrawString(familyName + tmpmsg, tmpFont, solidBrush, pointF);
                    //垂直坐标一移一行，行高为  字体的高度
                    pointF.Y += tmpFont.Height;
                }
                else
                {
                    graphics.DrawString(familyName + tmpmsg +
                        "  字体的斜体风格不可用", msgfont, solidBrush, pointF);
                    pointF.Y += msgfont.Height;
                }
                tmpmsg = string.Empty;

                // 查询下划线风格是否可用
                if (pFontFamily[j].IsStyleAvailable(FontStyle.Underline))
                {
                    tmpmsg = "  字体的下划线风格可用";
                    //构造字体
                    FontFamily fm = new FontFamily(familyName, privateFontCollection);
                    Font tmpFont = new Font(fm,
                        12, FontStyle.Underline, GraphicsUnit.Pixel);
                    //输出使用常规风格的字体
                    graphics.DrawString(familyName + tmpmsg, tmpFont, solidBrush, pointF);
                    //垂直坐标一移一行，行高为  字体的高度
                    pointF.Y += tmpFont.Height;
                }
                else
                {
                    graphics.DrawString(familyName + tmpmsg +
                        "  字体的下划线风格不可用", msgfont, solidBrush, pointF);
                    pointF.Y += msgfont.Height;
                }
                tmpmsg = string.Empty;

                // 查询强调线风格是否可用
                if (pFontFamily[j].IsStyleAvailable(FontStyle.Strikeout))
                {
                    tmpmsg = "  字体的强调线风格可用";
                    //构造字体
                    FontFamily fm = new FontFamily(familyName, privateFontCollection);
                    Font tmpFont = new Font(fm,
                        12, FontStyle.Strikeout, GraphicsUnit.Pixel);
                    //输出使用常规风格的字体
                    graphics.DrawString(familyName + tmpmsg, tmpFont, solidBrush, pointF);
                    //垂直坐标一移一行，行高为  字体的高度
                    pointF.Y += tmpFont.Height;
                }
                else
                {
                    graphics.DrawString(familyName + tmpmsg +
                        "  字体的强调线风格不可用", msgfont, solidBrush, pointF);
                    pointF.Y += msgfont.Height;
                }
                tmpmsg = string.Empty;

                // 在不同的字体系列之间加上间隔线
                graphics.DrawLine(pen, 0, (int)pointF.Y, 400, (int)pointF.Y);
                pointF.Y += 10.0f;
            }
        }
        //获取字体的大小
        private void Font_Size_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            PointF pointF = new PointF(0.0f, 0.0f);
            SolidBrush solidBrush = new SolidBrush(Color.Black);

            string infoString = string.Empty;
            int ascent;
            float ascentPixel;
            int descent;
            float descentPixel;
            int lineSpacing;
            float lineSpacingPixel;

            FontFamily fontFamily = new FontFamily("Arial");
            //创建一个大小为16像素的Aria字体
            Font font = new Font(fontFamily, 16, FontStyle.Regular, GraphicsUnit.Pixel);
            Font font2 = new Font(fontFamily, 14, FontStyle.Regular, GraphicsUnit.Pixel);

            // 显示字体大小
            infoString = string.Format("font的Size属性值为{0:F2}", font.Size);
            graphics.DrawString(infoString, font2, solidBrush, pointF);
            // 下移一行
            pointF.Y += font2.Height;
            //显示字体高度：像素
            infoString = string.Format("font的Height属性值为{0:F2}", font.Height);
            graphics.DrawString(infoString, font2, solidBrush, pointF);
            // 下移一行
            pointF.Y += font2.Height;

            // 显示字体系列的高度(设计单位)
            infoString = string.Format("使用fontFamily.GetEmHeight函数返回的字体高度为{0}个设计单位。"
                , fontFamily.GetEmHeight(FontStyle.Regular));
            graphics.DrawString(infoString, font2, solidBrush, pointF);

            // 下移两行(Height属性的值是字体的高度，单位为像素)
            pointF.Y += 2.0f * font2.Height;

            // 获取字体的Ascent(上部距离)
            ascent = fontFamily.GetCellAscent(FontStyle.Regular);

            //将上部距离的设计单位转换成像素单位
            ascentPixel =
                font.Size * ascent / fontFamily.GetEmHeight(FontStyle.Regular);
            infoString = string.Format("上部距离为{0}个设计单位, {1:F2}个像素。",
                ascent, ascentPixel);
            graphics.DrawString(infoString, font2, solidBrush, pointF);

            // 下移一行
            pointF.Y += font2.Height;
            // 获取字体的Descent(下部距离),设计单位
            descent = fontFamily.GetCellDescent(FontStyle.Regular);

            //将下部距离的设计单位转换成像素单位
            descentPixel =
                font.Size * descent / fontFamily.GetEmHeight(FontStyle.Regular);
            infoString = string.Format("下部距离为{0} 个设计单位,{1:F2}个像素。",
                descent, descentPixel);
            graphics.DrawString(infoString, font2, solidBrush, pointF);

            // 下移一行
            pointF.Y += font2.Height;
            //获取行距(设计单位)
            lineSpacing = fontFamily.GetLineSpacing(FontStyle.Regular);
            //将行距的设计单位转换成像素单位
            lineSpacingPixel =
                font.Size * lineSpacing / fontFamily.GetEmHeight(FontStyle.Regular);
            infoString = string.Format("行距为{0} 个设计单位,{1:F2} 像素。",
                lineSpacing, lineSpacingPixel);
            graphics.DrawString(infoString, font2, solidBrush, pointF);
        }
        //设置文本输出基线
        private void Font_BaseLine_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            FontFamily fontFamily = new FontFamily("Arial");
            //创建一个大小为60像素的Aria字体
            Font font = new Font(fontFamily, 60, FontStyle.Regular, GraphicsUnit.Pixel);
            //获取当前窗口的矩形宽、高
            int cy = this.Height;
            int cx = this.Width;

            Pen pen = new Pen(Color.Blue, 1);
            SolidBrush brush = new SolidBrush(Color.Blue);

            //将窗口垂直方向的1/2部分作为基线
            float yBaseline = cy / 2;
            //绘制基线
            graphics.DrawLine(pen, new PointF(0, yBaseline), new PointF(cx, yBaseline));
            //得到字体高度
            float cyLineSpace = font.Height;
            //获取行距
            int iCellSpace = fontFamily.GetLineSpacing(FontStyle.Regular);
            //得到上半部分距离
            int iCellAscent = fontFamily.GetCellAscent(FontStyle.Regular);
            //计算文本输出的起始位置相对于基线的偏移
            float cyAscent = cyLineSpace * iCellAscent / iCellSpace;

            //从中央向上绘制两条直线，间隔为cyAscent
            graphics.DrawLine(pen,
                new PointF(0, yBaseline - cyAscent), new PointF(cx, yBaseline - cyAscent));
            graphics.DrawLine(pen,
                new PointF(0, yBaseline - 2.0f * cyAscent), new PointF(cx, yBaseline - 2.0f * cyAscent));

            //分别在两条基线上输出文本
            graphics.DrawString("AaFfgSs}", font, brush, new PointF(0, yBaseline - cyAscent));
            graphics.DrawString("AaFfgSs}", font, brush, new PointF(0, yBaseline - 2.0f * cyAscent));

        }

        private void Font_DrawString_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //输出文本
            string msg = "示例文本";

            Font myFont = new Font("宋体", 16);
            Rectangle layoutRect = new Rectangle(50, 50, 200, 50);
            //设置对齐方式
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            SolidBrush blackBrush = new SolidBrush(Color.Black);

            // 绘制文本
            graphics.DrawString(msg, myFont, blackBrush, layoutRect, format);
            // 绘制文本输出的矩形区域
            graphics.DrawRectangle(new Pen(Color.Black, 3), layoutRect);

        }

        private void Font_MeasureString_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //设置一个包含三行文本的字符串
            string txtOut = "123456789\n";
            txtOut += "ABCDEFGHIJKLM\n";
            txtOut += "一二三四五六七八九";

            FontFamily fontFamily = new FontFamily("Arial");
            //创建两个个大小不同的Aria字体
            Font font = new Font(fontFamily, 30, FontStyle.Regular, GraphicsUnit.Pixel);
            Font font2 = new Font(fontFamily, 14, FontStyle.Regular, GraphicsUnit.Pixel);
            SolidBrush brush = new SolidBrush(Color.Black);

            StringFormat fmt = new StringFormat();
            fmt.Alignment = StringAlignment.Center;
            fmt.LineAlignment = StringAlignment.Center;

            SizeF stringSize = new SizeF();
            //测量输出字符串所需要的矩形空间
            stringSize = graphics.MeasureString(txtOut, font);

            string tmp = string.Empty;
            tmp = string.Format("输出字符串所需要的宽度为:{0:F2}  高度为{1:F2}",
                stringSize.Width, stringSize.Height, font.Height);

            // 绘制输出文本的限制矩形
            graphics.DrawRectangle(new Pen(Color.Red),
                10.0f, 10.0f, stringSize.Width, stringSize.Height);
            //输出字符串的测量信息
            graphics.DrawString(txtOut, font, brush,
                new RectangleF(10.0f, 10.0f, stringSize.Width, stringSize.Height), fmt);
            graphics.TranslateTransform(0, 10 + stringSize.Height);
            graphics.DrawString(tmp, font2, brush, new PointF(0, 0));
        }
        //计算在指定的区域中显示的字符总数及行数
        private void Font_MeasureString2_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            string txtOut = "123456789";
            txtOut += "ABCDEFGHIJKLM";
            txtOut += "一二三四五六七八九";

            FontFamily fontFamily = new FontFamily("Arial");
            //创建两个个大小不同的Aria字体
            Font font = new Font(fontFamily, 30, FontStyle.Regular, GraphicsUnit.Pixel);
            Font font2 = new Font(fontFamily, 14, FontStyle.Regular, GraphicsUnit.Pixel);
            //设置文本输出矩形
            Rectangle layoutRect = new Rectangle(10, 10, 100, 100);
            SolidBrush brush = new SolidBrush(Color.Black);

            //设置文本显示格式
            StringFormat fmt = new StringFormat();
            fmt.Alignment = StringAlignment.Center;
            fmt.LineAlignment = StringAlignment.Center;

            int codepointsFitted = 0;
            int linesFilled = 0;

            SizeF stringSize = new SizeF();
            //计算指定的区域能够显示的字符总数及行数
            stringSize = graphics.MeasureString(txtOut,
                font, new SizeF(layoutRect.Width, layoutRect.Height),
                fmt, out codepointsFitted, out linesFilled);

            string tmp = string.Empty;
            tmp = string.Format("欲输出的字串共{0}个字符\n其中,在指定的输出矩形中\n只输出了{1}行共{2}个字符", txtOut.Length, linesFilled, codepointsFitted);

            // 绘制指定的文本输出区域
            graphics.DrawRectangle(new Pen(Color.Blue, 2), layoutRect);
            //在指定的区域矩形中显示文本
            graphics.DrawString(txtOut, font, brush, layoutRect, fmt);

            //输出字符串的测量信息
            graphics.TranslateTransform(0, 10 + stringSize.Height);
            graphics.DrawString(tmp, font2, brush, new PointF(0, 0));
        }
        //文本的分栏输出
        private void Font_ColumnTextOut_Click(object sender, System.EventArgs e)
        {
            //选定欲分栏显示的文件
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowReadOnly = true;
            //文件对话框标题
            dlg.Title = "选择欲分栏显示的文本文件";
            dlg.Filter = "文本文件 (*.txt)|*.txt|所有文件 (*.*)|*.*";
            //选择了取消
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            StreamReader stream = new StreamReader(dlg.FileName,
                System.Text.Encoding.Unicode);
            string buffer = string.Empty;
            //读取所有的文件内容	
            buffer = stream.ReadToEnd();
            //关闭文件
            stream.Close();
            String str = buffer;

            //定义栏宽及栏与栏之间的间隔
            int COLUMWIDTH = 100;
            int SPACE = 10;

            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush brush = new SolidBrush(Color.Black);
            Font myFont = new Font("宋体", 10);
            int codepointsFitted = 0;
            int linesFilled = 0;

            //设置输出格式
            StringFormat format = new StringFormat();
            //禁用自动剪载
            format.FormatFlags = StringFormatFlags.NoClip;
            //输出文本以单词结束
            format.Trimming = StringTrimming.Word;

            //从左至右按列(栏)输出文本
            for (int x = 0; str.Length > 0 && x < this.Width; x += (COLUMWIDTH + SPACE))
            {
                //设置文本对应的矩形区域(一栏)
                RectangleF layoutRect = new RectangleF(x, 0,
                    COLUMWIDTH, this.Height - myFont.Height);
                SizeF stringSize = new SizeF();
                //计算指定的区域能够显示的字符总数及行数
                stringSize = graphics.MeasureString(str,
                    myFont, new SizeF(layoutRect.Width, layoutRect.Height),
                    format, out codepointsFitted, out linesFilled);

                //显示一栏文本
                graphics.DrawString(str, myFont, brush, layoutRect, format);
                //去掉已经输出的字符，以便下一栏能够正常显示			  
                str = str.Substring(codepointsFitted);
            }
        }
        //设置文本的去尾方式
        private void Font_StirngTrimming_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush solidBrush = new SolidBrush(Color.Black);
            FontFamily fontFamily = new FontFamily("Times New Roman");
            //用于文本输出的字体
            Font font = new Font(fontFamily, 25, FontStyle.Regular, GraphicsUnit.Pixel);

            Pen pen = new Pen(Color.Red);
            StringFormat stringFormat = new StringFormat();
            //用于提示信息的字体及格式
            Font font2 = new Font(fontFamily, 14, FontStyle.Regular, GraphicsUnit.Pixel);
            //设置文本输出的格式
            StringFormat msgFormat = new StringFormat();
            msgFormat.Alignment = StringAlignment.Center;
            msgFormat.LineAlignment = StringAlignment.Center;

            //提示信息输出区域
            RectangleF outrect = new RectangleF(30, 100, 160, font2.Height * 2);

            //去尾方式：Character
            stringFormat.Trimming = StringTrimming.Character;
            //输出文本
            string text = "One two three four five seven eight nine ten";
            graphics.DrawString(text, font, solidBrush,
                new Rectangle(30, 30, 160, 60),
                stringFormat);

            //绘制文本输出区域
            graphics.DrawRectangle(pen, 30, 30, 160, 60);
            //输出提示信息
            graphics.DrawString("Character", font2, solidBrush, outrect,
                msgFormat);

            //绘图平面沿水平方向平移160个像素
            graphics.TranslateTransform(160, 0);

            //更改去尾方式：Word
            stringFormat.Trimming = StringTrimming.Word;
            graphics.DrawString(text, font, solidBrush,
                new Rectangle(30, 30, 160, 60),
                stringFormat);
            graphics.DrawRectangle(pen, 30, 30, 160, 60);
            graphics.DrawString("Word", font2, solidBrush, outrect,
                msgFormat);


            //更改去尾方式：EllipsisCharacter
            graphics.TranslateTransform(160, 0);
            stringFormat.Trimming = StringTrimming.EllipsisCharacter;
            graphics.DrawString(text, font, solidBrush,
                new Rectangle(30, 30, 160, 60),
                stringFormat);
            graphics.DrawRectangle(pen, 30, 30, 160, 60);
            graphics.DrawString("EllipsisCharacter", font2, solidBrush, outrect,
                msgFormat);


            //更改去尾方式：EllipsisWord
            graphics.TranslateTransform(160, 0);
            stringFormat.Trimming = StringTrimming.EllipsisWord;
            graphics.DrawString(text, font, solidBrush,
                new Rectangle(30, 30, 160, 60),
                stringFormat);
            graphics.DrawRectangle(pen, 30, 30, 160, 60);
            graphics.DrawString("EllipsisWord", font2, solidBrush, outrect,
                msgFormat);

            //更改去尾方式：EllipsisPath
            graphics.TranslateTransform(160, 0);
            stringFormat.Trimming = StringTrimming.EllipsisPath;
            graphics.DrawString(text, font, solidBrush,
                new Rectangle(30, 30, 160, 60),
                stringFormat);
            graphics.DrawRectangle(pen, 30, 30, 160, 60);
            graphics.DrawString("EllipsisPath", font2, solidBrush, outrect,
                msgFormat);

        }
        //文本输出的剪裁处理
        private void Font_TextOutClip_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush solidBrush = new SolidBrush(Color.Black);
            FontFamily fontFamily = new FontFamily("宋体");
            Font font = new Font(fontFamily, 25,
                FontStyle.Regular, GraphicsUnit.Pixel);

            Pen pen = new Pen(Color.Red);
            StringFormat stringFormat = new StringFormat();
            RectangleF outtext = new RectangleF(10, 10, 120, 45);
            //使用默认值输出文本
            string text = "文本的剪裁示意";
            graphics.DrawString(text, font, solidBrush, outtext,
                stringFormat);
            //绘制文本输出区域
            graphics.DrawRectangle(pen, outtext.X,
                outtext.Y, outtext.Width, outtext.Height);

            //在水平方向平移170个像素更
            graphics.TranslateTransform(120, 0);
            RectangleF out2 = outtext;
            //将输出区域的高度调整为字体高度的整数倍
            out2.Height = font.Height * 2;
            graphics.DrawString(text, font, solidBrush, out2,
                stringFormat);
            //绘制文本输出区域
            graphics.DrawRectangle(pen, out2.X,
                out2.Y, out2.Width, out2.Height);

            graphics.TranslateTransform(120, 0);
            //在输出文本时不使用剪截
            stringFormat.FormatFlags = StringFormatFlags.NoClip;
            graphics.DrawString(text, font, solidBrush, outtext,
                stringFormat);

            //绘制文本输出区域
            graphics.DrawRectangle(pen, outtext.X, outtext.Y,
                outtext.Width, outtext.Height);
        }
        //测量文本局部输出区域
        private void Font_MeasureCharacterRanges_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            // 设置绘制文本、填充区域的画刷
            SolidBrush TextBrush = new SolidBrush(Color.Red);
            SolidBrush RegionBrush = new SolidBrush(Color.FromArgb(100, Color.Black));
            Pen blackPen = new Pen(Color.Black);

            // 使用三个宽度不同的矩形区域绘制文本，示意不同局部区域测量结果
            RectangleF layoutRect_A = new RectangleF(20.0f, 20.0f, 120.0f, 180.0f);
            RectangleF layoutRect_B = new RectangleF(140.0f, 20.0f, 140.0f, 180.0f);
            RectangleF layoutRect_C = new RectangleF(280.0f, 20.0f, 180.0f, 180.0f);

            //添加需要输出的字串
            string ts = "秦时明月汉时关，";
            ts += "万里长征人未还。";
            ts += "但使龙城飞将在，";
            ts += "不教胡马度阴山。";

            // 在字串中需要局部测量的文本定义区域：每行诗的最后三个字
            CharacterRange[] charRanges = new CharacterRange[] 
		{ 
			new CharacterRange(4, 3),
			new CharacterRange(12, 3),
			new CharacterRange(20, 3), 
			new CharacterRange(28, 3)
		};

            // 绘制文本时使用的字体及大小 
            FontFamily fontFamily = new FontFamily("华文新魏");
            Font myFont = new Font(fontFamily, 25, FontStyle.Italic, GraphicsUnit.Pixel);

            StringFormat strFormat = new StringFormat();
            //指向需要局部测量区域的数组
            Region[] CharRangeRegions = new Region[4];

            //在字体格式中设置需要局部测量的区域
            strFormat.SetMeasurableCharacterRanges(charRanges);

            //在矩形layoutRect_A中对文本进行局部测量，测量的结果保存在CharRangeRegions中
            CharRangeRegions = graphics.MeasureCharacterRanges(ts, myFont, layoutRect_A, strFormat);
            //输出文本
            graphics.DrawString(ts,
                myFont, TextBrush, layoutRect_A, strFormat);
            //绘制文本输出边框
            graphics.DrawRectangle(blackPen,
                layoutRect_A.X, layoutRect_A.Y, layoutRect_A.Width, layoutRect_A.Height);
            short i;
            //填充由CharRangeRegions保存的区域
            for (i = 0; i < 4; i++)
            {
                graphics.FillRegion(RegionBrush, CharRangeRegions[i]);
            }

            //在矩形layoutRect_B中对文本进行局部测量，测量的结果保存在CharRangeRegions中
            CharRangeRegions = graphics.MeasureCharacterRanges(ts, myFont, layoutRect_B, strFormat);
            //输出文本
            graphics.DrawString(ts, myFont, TextBrush, layoutRect_B, strFormat);
            graphics.DrawRectangle(blackPen,
                layoutRect_B.X, layoutRect_B.Y, layoutRect_B.Width, layoutRect_B.Height);
            //填充区域
            for (i = 0; i < 4; i++)
            {
                graphics.FillRegion(RegionBrush, CharRangeRegions[i]);
            }

            //在矩形layoutRect_c中对文本进行局部测量，测量的结果保存在CharRangeRegions中
            CharRangeRegions = graphics.MeasureCharacterRanges(ts, myFont, layoutRect_C, strFormat);
            //输出文本
            graphics.DrawString(ts, myFont, TextBrush, layoutRect_C, strFormat);
            graphics.DrawRectangle(blackPen,
                layoutRect_C.X, layoutRect_C.Y, layoutRect_C.Width, layoutRect_C.Height);
            //填充区域
            for (i = 0; i < 4; i++)
            {
                graphics.FillRegion(RegionBrush, CharRangeRegions[i]);
            }

        }
        //控件文本输出方向
        private void Font_TextoutDirection_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //添加需要输出的字串
            string ts = "秦时明月汉时关，";
            ts += "万里长征人未还。";
            ts += "但使龙城飞将在，";
            ts += "不教胡马度阴山。";

            //设置输出字体
            FontFamily fontFamily = new FontFamily("幼圆");
            Font myFont = new Font(fontFamily, 20, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush brush = new SolidBrush(Color.Red);
            Pen pen = new Pen(Color.Black);

            //设置输出区间
            Rectangle f = new Rectangle(10, 10, 120, myFont.Height * 8);
            //构造StringFormat对象
            StringFormat strFormat = new StringFormat();
            //从至左输出文本
            StringFormatFlags flag = StringFormatFlags.DirectionRightToLeft;
            //文本在竖直方向上输出
            flag |= StringFormatFlags.DirectionVertical;
            //设置输出格式标志
            strFormat.FormatFlags = flag;

            //设置文本对齐方式
            strFormat.Alignment = StringAlignment.Center;
            strFormat.LineAlignment = StringAlignment.Center;

            //绘制输出区间及文本
            graphics.DrawRectangle(pen, f);
            graphics.DrawString(ts, myFont, brush, f, strFormat);
        }
        //设置文本对齐方式
        private void Font_TextAlignment_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //将当前窗口大小信息保存
            Rectangle rect = new Rectangle(0, 0,
                this.ClientSize.Width, this.ClientSize.Height);
            SolidBrush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Gray);

            //以当前窗口中心点为原点绘制坐标轴
            graphics.DrawLine(pen,
                new PointF(rect.Width / 2, 0), new PointF(rect.Width / 2, rect.Height));
            graphics.DrawLine(pen,
                new PointF(0, rect.Height / 2), new PointF(rect.Width, rect.Height / 2));

            //将StringAlignment枚举的三种不同的对齐方式设置成数组成员，以便直接访问
            StringAlignment[] Align = new StringAlignment[3]
		{
			StringAlignment.Near,
			StringAlignment.Center,
			StringAlignment.Far
		};
            string[] strAlign = new string[] { "近", "中", "远" };

            //设置输出字体
            FontFamily fontFamily = new FontFamily("幼圆");
            Font font = new Font(fontFamily, 12, FontStyle.Regular);
            StringFormat strfmt = new StringFormat();

            //分别在垂直和水平方向上使用三种不同的对齐方式
            for (int iVert = 0; iVert < 3; iVert++)
                for (int iHorz = 0; iHorz < 3; iHorz++)
                {
                    //设置垂直对齐方式
                    strfmt.LineAlignment = (StringAlignment)Align[iVert];
                    //设置水平对齐方式
                    strfmt.Alignment = (StringAlignment)Align[iHorz];
                    //将对齐信息输出
                    string s = string.Empty;
                    s = string.Format("水平对齐:{0}\n垂直对齐:{1}",
                        strAlign[iVert], strAlign[iHorz]);

                    //在当前区域中按照设置的对齐方式绘制文本
                    graphics.DrawString(s, font, brush, rect, strfmt);
                }
        }

        private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }



        private void Form1_Resize(object sender, System.EventArgs e)
        {
            ////this.Invalidate();
        }

        private void Font_TextAlignment2_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //将当前窗口大小信息保存
            Rectangle rect = new Rectangle(0, 0,
                this.ClientSize.Width, this.ClientSize.Height);
            SolidBrush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Gray);

            //以当前窗口中心点为原点绘制坐标轴
            graphics.DrawLine(pen,
                new PointF(rect.Width / 2, 0), new PointF(rect.Width / 2, rect.Height));
            graphics.DrawLine(pen,
                new PointF(0, rect.Height / 2), new PointF(rect.Width, rect.Height / 2));

            //将StringAlignment枚举的三种不同的对齐方式设置成数组成员，以便直接访问
            StringAlignment[] Align = new StringAlignment[3]
		{
			StringAlignment.Near,
			StringAlignment.Center,
			StringAlignment.Far
		};
            string[] strAlign = new string[] { "近", "中", "远" };

            //设置输出字体
            FontFamily fontFamily = new FontFamily("幼圆");
            Font font = new Font(fontFamily, 12, FontStyle.Regular);
            StringFormat strfmt = new StringFormat();

            //分别在垂直和水平方向上使用三种不同的对齐方式
            for (int iVert = 0; iVert < 3; iVert += 2)
                for (int iHorz = 0; iHorz < 3; iHorz += 2)
                {
                    //设置垂直对齐方式
                    strfmt.LineAlignment = (StringAlignment)Align[iVert];
                    //设置水平对齐方式
                    strfmt.Alignment = (StringAlignment)Align[iHorz];
                    //将对齐信息输出
                    string s = string.Empty;
                    s = string.Format("水平对齐:{0}\n垂直对齐:{1}",
                        strAlign[iVert], strAlign[iHorz]);

                    //在当前区域中按照设置的对齐方式绘制文本
                    graphics.DrawString(s, font, brush, new PointF(this.ClientSize.Width / 2, this.ClientSize.Height / 2), strfmt);
                }
        }
        //使用制表位
        private void Font_TextoutUsingTabs_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            StringFormat stringFormat = new StringFormat();
            //输出文本使用的字体
            FontFamily fontFamily = new FontFamily("Arial");
            Font font = new Font(fontFamily, 30, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush solidBrush = new SolidBrush(Color.Black);

            //不使用制表位信息的输出
            string text = "A\tB\tC\t\t\tD";
            graphics.DrawString(text, font, solidBrush, new PointF(0, 10), stringFormat);

            //设置制表位信息1
            float[] tabs = new float[] { 40.0f, 30.0f, 40 };
            stringFormat.SetTabStops(0.0f, tabs);

            //使用制表位信息的进行文本输出
            graphics.TranslateTransform(0, 30);
            text = "A\tB\tC\tD";
            graphics.DrawString(text, font, solidBrush, new PointF(0, 10), stringFormat);

            //设置制表位信息2
            float[] tabs2 = { 60.0f, 60.0f, 60 };
            stringFormat.SetTabStops(0.0f, tabs2);
            graphics.TranslateTransform(0, 30);
            graphics.DrawString(text, font, solidBrush, new PointF(0, 10), stringFormat);

            //获取制表信息	
            float firstTabOffset = 0;
            float[] tabStops = stringFormat.GetTabStops(out firstTabOffset);

            //清空制表位
            for (int j = 0; j < 3; ++j)
                tabStops[j] = 0;
            stringFormat.SetTabStops(0.0f, tabStops);

            //在清空制表位信息后输出文本
            graphics.TranslateTransform(0, 30);
            graphics.DrawString(text, font, solidBrush, new PointF(0, 10), stringFormat);
        }

        //定义商品信息结构
        struct SListItem
        {
            public string name;//商品名
            public float price;//单价
            public float num;//数量
            //初如化
            public SListItem(string p1, float p2, float p3)
            {
                name = p1;
                price = p2;
                num = p3;
            }
        };
        private void Font_UsingTabs_Click(object sender, System.EventArgs e)
        {

            //初始化商品信息
            SListItem[] items = new SListItem[5];
            items[0] = new SListItem("MP3播放机", 1228, 10);
            items[1] = new SListItem("笔记本电脑", 17200, 1);
            items[2] = new SListItem("激光打印机", 3200, 5);
            items[3] = new SListItem("喷墨打印机", 620, 1);
            items[4] = new SListItem("数码相机", 4800, 5);

            //定义表头
            string title = string.Empty;
            title = string.Format("\n{0}\t{1}\t{2}\t{3}\n", "商品名", "单价", "数量", "总价");
            //格式化每种商品对应的字符串
            string[] iteminfo = new string[5];
            for (int i = 0; i < 5; i++)
            {
                //计算总价
                float total = items[i].price * items[i].num;
                //定制输出格式
                string s = string.Empty;
                s = string.Format("{0}\t{1:F2}\t{2:F2}\t{3:F2}\n",
                    items[i].name, items[i].price, items[i].num, total);
                iteminfo[i] = s;
            }

            //在表格每一行的内容合并
            string xxx = string.Empty; ;
            for (int i = 0; i < 5; i++)
                xxx += iteminfo[i];
            //表头+表体
            title += xxx;

            //在当前窗口中输出表格
            RectangleF rect = new RectangleF(0.0f, 0.0f,
                this.ClientSize.Width, this.ClientSize.Height);

            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush solidBrush = new SolidBrush(Color.Black);
            //定制输出字体
            FontFamily fontFamily = new FontFamily("宋体");
            Font font = new Font(fontFamily,
                16, FontStyle.Regular, GraphicsUnit.Pixel);

            StringFormat stringFormat = new StringFormat();
            //设置制表位信息
            float[] tabs = new float[] { 120.0f, 120.0f, 60.0f };
            stringFormat.SetTabStops(0.0f, tabs);
            //输出表格
            graphics.DrawString(title, font, solidBrush, rect, stringFormat);
        }

        private void Font_TextoutHotkeyPrefix_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush solidBrush = new SolidBrush(Color.Black);
            FontFamily fontFamily = new FontFamily("宋体");
            Font font = new Font(fontFamily, 20, FontStyle.Regular, GraphicsUnit.Pixel);
            Pen pen = new Pen(Color.Red);

            StringFormat stringFormat = new StringFormat();
            //显示快捷键字符，不解释"&"号
            stringFormat.HotkeyPrefix = HotkeyPrefix.None;
            graphics.DrawString("工具栏(&T )\n状态栏(&S )", font, solidBrush,
                new RectangleF(30, 30, 160, font.Height * 2), stringFormat);

            //绘制边框
            graphics.DrawRectangle(pen, new Rectangle(30, 30, 160, font.Height * 2));

            //解释""号为下划线
            stringFormat.HotkeyPrefix = HotkeyPrefix.Show;
            graphics.TranslateTransform(0, font.Height * 3);
            graphics.DrawString("工具栏(&T )\n状态栏(&S )", font, solidBrush,
                new RectangleF(30, 30, 160, font.Height * 2), stringFormat);

            //绘制边框
            graphics.DrawRectangle(pen, new Rectangle(30, 30, 160, font.Height * 2));

            //隐藏""号
            graphics.TranslateTransform(0, font.Height * 3);
            stringFormat.HotkeyPrefix = HotkeyPrefix.Hide;
            graphics.DrawString("工具栏(&T )\n状态栏(&S )", font, solidBrush,
                new RectangleF(30, 30, 160, font.Height * 2), stringFormat);

            graphics.DrawRectangle(pen, new Rectangle(30, 30, 160, font.Height * 2));

        }

        private void Font_TextoutShadow_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);
            //对文本使用去锯齿的边缘处理
            graphics.TextRenderingHint = TextRenderingHint.AntiAlias;

            FontFamily fontFamily = new FontFamily("楷体_GB2312_GB2312");
            Font font = new Font(fontFamily, 100, FontStyle.Bold, GraphicsUnit.Pixel);

            //文本输出框
            RectangleF textout = new RectangleF(font.Height,
                this.ClientSize.Height / 2, this.ClientSize.Width, this.ClientSize.Height);

            //在两个不同的位置绘制文本，形成阴影
            //solidBrush的色彩透明度为100，暗黑
            SolidBrush solidBrush = new SolidBrush(Color.FromArgb(100, Color.Black));
            SolidBrush redBrush = new SolidBrush(Color.Red);
            graphics.DrawString("阴影字", font, solidBrush,
                new PointF(27.0f, 27.0f));
            graphics.DrawString("阴影字", font, redBrush,
                new PointF(12.0f, 20.0f));

            //另一种阴影字，阴影为线条
            //构造影线画刷
            HatchBrush brush_tmp = new HatchBrush(
                HatchStyle.DarkDownwardDiagonal, Color.Black, Color.White);

            int reptime = 40;
            //先画背景
            for (int i = 0; i < reptime; i++)
                graphics.DrawString("阴影字", font, brush_tmp,
                    new PointF(textout.X + i + 2, textout.Y + i + 2));

            //再画前景
            graphics.DrawString("阴影字", font, Brushes.Red, new PointF(textout.X, textout.Y));
        }

        private void Font_TextoutHashline_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);
            //对文本使用去锯齿的边缘处理
            graphics.TextRenderingHint = TextRenderingHint.AntiAlias;

            FontFamily fontFamily = new FontFamily("楷体_GB2312_GB2312");
            Font font = new Font(fontFamily, 100, FontStyle.Bold, GraphicsUnit.Pixel);

            //文本输出框
            RectangleF textout = new RectangleF(font.Height, 0, this.Width, this.Height);
            //画刷样本显示框
            RectangleF brushdemo = new RectangleF(0, 0, font.Height, font.Height);
            //创建一个影线画刷
            HatchBrush brush_tmp = new HatchBrush(HatchStyle.Percent75, Color.Black, Color.White);

            //设置文本输出格式：水平靠左、垂直居中
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Near;
            format.LineAlignment = StringAlignment.Center;

            //显示画刷样本
            graphics.FillRectangle(brush_tmp, brushdemo);
            //使用画刷绘制文本
            graphics.DrawString("影线字", font, brush_tmp, textout, format);

        }

        private void Font_TextoutTexture_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);
            //对文本使用去锯齿的边缘处理
            graphics.TextRenderingHint = TextRenderingHint.AntiAlias;

            FontFamily fontFamily = new FontFamily("GB2312");
            Font font = new Font(fontFamily, 70, FontStyle.Bold, GraphicsUnit.Pixel);

            //文本输出框
            RectangleF textout = new RectangleF(0, 0,
                this.ClientSize.Width, this.ClientSize.Height);
            //画刷样本显示框
            RectangleF brushdemo = new RectangleF(0, 0, font.Height, font.Height);

            //装入纹理图片
            Bitmap image = new Bitmap("TEXTURE3.bmp");
            //构造纹理画刷
            TextureBrush brush_tmp = new TextureBrush(image);

            //设置文本输出格式：水平、垂直居中
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;

            //显示画刷样本
            graphics.FillRectangle(brush_tmp, brushdemo);
            //使用画刷绘制文本
            graphics.DrawString("纹理字", font, brush_tmp, textout, format);
        }

        private void Font_TextoutGradient_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);
            //对文本使用去锯齿的边缘处理
            graphics.TextRenderingHint = TextRenderingHint.AntiAlias;

            FontFamily fontFamily = new FontFamily("楷体_GB2312_GB2312");
            Font font = new Font(fontFamily, 70, FontStyle.Bold, GraphicsUnit.Pixel);

            RectangleF textout = new RectangleF(0, 0,
                this.ClientSize.Width, this.ClientSize.Height);
            //画刷样本显示框
            RectangleF brushdemo = new RectangleF(0, 0, font.Height, font.Height);
            //定义一个多色渐变画刷
            Color[] colors = new Color[]
			{
				Color.Red,   // 红色
				Color.Green,//过度色为绿色
				Color.Blue  // 蓝色
			};
            float[] positions = new float[]
			{
				0.0f,   // 由红色起
				0.3f,   // 绿色始于画刷长度的三分之一
				1.0f // 由蓝色止
			};

            //构造一条从黑色到白色的渐变画刷
            LinearGradientBrush brush_tmp = new LinearGradientBrush(
                new Point(0, 0),
                new Point(100, font.Height),
                Color.White,         // 黑
                Color.White);  // 白

            //设置渐变画刷的多色渐变信息
            ColorBlend clrBlend = new ColorBlend(3);
            clrBlend.Colors = colors;
            clrBlend.Positions = positions;
            brush_tmp.InterpolationColors = clrBlend;

            //设置文本输出格式：水平靠左、垂直居中
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Near;
            format.LineAlignment = StringAlignment.Center;
            //显示画刷样本
            graphics.FillRectangle(brush_tmp, brushdemo);
            //使用画刷绘制文本
            graphics.DrawString("渐变字", font, brush_tmp, textout, format);
        }
        //构造路径
        private void Path_Construct_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //定义构成路径的点坐标
            PointF[] data = new PointF[]
		{
			new PointF(40,140),
			new PointF(275,200),
			new PointF(105,225),
			new PointF(190,300),
			new PointF(50,350),
			new PointF(20,180)
		};

            //设置定义点的类型将每点都处理成直线的端点
            byte[] typeline = new byte[]
	{
		(byte)PathPointType.Line,
		(byte)PathPointType.Line,
		(byte)PathPointType.Line,
		(byte)PathPointType.Line,
		(byte)PathPointType.Line,
		(byte)PathPointType.Line
	};

            //构造路径
            GraphicsPath tmp1 = new GraphicsPath(data, typeline);
            //填充路径
            graphics.FillPath(Brushes.Red, tmp1);

            //绘制定义路径的端点
            for (int i = 0; i < 6; i++)
                graphics.FillEllipse(Brushes.Black,
                    new RectangleF(data[i].X - 5, data[i].Y - 5, 10, 10));

            //绘图平面右移
            graphics.TranslateTransform(360, 0);

            //更改路径的端点类型
            byte[] type = new byte[]
		{
			(byte)PathPointType.Start,
			(byte)PathPointType.Bezier,
			(byte)PathPointType.Bezier,
			(byte)PathPointType.Bezier,
			(byte)PathPointType.Line,
			(byte)PathPointType.Line
		};
            //构造并填充路径
            GraphicsPath tmp = new GraphicsPath(data, type);
            graphics.FillPath(Brushes.Red, tmp);

            //绘制定义路径的端点
            for (int i = 0; i < 6; i++)
                graphics.FillEllipse(Brushes.Black,
                    new RectangleF(data[i].X - 5, data[i].Y - 5, 10, 10));
        }

        private void Path_AddLines_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Blue, 2);
            //创建路径对象
            GraphicsPath path = new GraphicsPath();

            Rectangle rect1 = new Rectangle(20, 20, 100, 200);
            Rectangle rect2 = new Rectangle(40, 40, 100, 200);
            //添加两段弧线
            path.AddArc(rect1, 0.0f, 180.0f);
            path.AddArc(rect2, 0.0f, 180.0f);
            graphics.DrawPath(pen, path);
        }
        //封闭图形
        private void Path_CloseFigure_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Blue, 2);
            //创建路径对象
            GraphicsPath path = new GraphicsPath();

            Rectangle rect1 = new Rectangle(20, 20, 100, 200);
            Rectangle rect2 = new Rectangle(40, 40, 100, 200);
            GraphicsPath path2 = new GraphicsPath();
            path2.AddArc(rect1, 0.0f, 180.0f);
            //封闭弧线1
            path2.CloseFigure();
            path2.AddArc(rect2, 0.0f, 180.0f);
            //封闭弧线2
            path2.CloseFigure();
            graphics.DrawPath(pen, path2);
        }
        //路径的填充
        private void Path_FillPath_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            GraphicsPath path1 = new GraphicsPath();
            GraphicsPath path = new GraphicsPath();
            Pen pen = new Pen(Color.FromArgb(128, Color.Blue), 5);
            SolidBrush brush = new SolidBrush(Color.Red);

            //添加三条直线：开放的图形
            path1.AddLine(10, 10, 10, 50);
            path1.AddLine(10, 50, 50, 50);
            path1.AddLine(50, 50, 50, 10);
            path1.StartFigure();

            //添加一个闭合的图形
            RectangleF rect = new RectangleF(110, 10, 40, 40);
            //开始第二个子路径的图形追加
            path1.AddRectangle(rect);
            //绘制、填充路径
            graphics.DrawPath(pen, path1);
            graphics.FillPath(brush, path1);

            //添加开放的弧线
            path.AddArc(0, 0, 150, 120, 30, 120);
            //添加封闭的椭圆
            path.AddEllipse(50, 50, 50, 100);

            //使用默认的填充方式填充路径
            graphics.FillPath(brush, path);
            graphics.DrawPath(pen, path);
        }

        private void Path_AddSubPath_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Blue, 2);
            Rectangle rect = new Rectangle(0, 0, 100, 50);
            GraphicsPath path = new GraphicsPath();

            //在路径中按垂直方向添加五段弧线
            path.AddArc(0, 0, 100, 50, 0.0f, 180.0f);
            path.AddArc(0, 30, 100, 50, 0.0f, 180.0f);
            path.AddArc(0, 60, 100, 50, 0.0f, 180.0f);
            path.AddArc(0, 90, 100, 50, 0.0f, 180.0f);
            path.AddArc(0, 120, 100, 50, 0.0f, 180.0f);
            graphics.DrawPath(pen, path);

            //获取路径所占区域
            RectangleF rect2 = path.GetBounds();

            //绘图平面右移
            graphics.TranslateTransform(rect2.Width + 10, 0);

            GraphicsPath path2 = new GraphicsPath();
            //构造第一个子路径
            path2.AddArc(0, 0, 100, 50, 0.0f, 180.0f);
            path2.AddArc(0, 30, 100, 50, 0.0f, 180.0f);
            path2.AddArc(0, 60, 100, 50, 0.0f, 180.0f);

            //在不封闭当前子路径的情况下开始第二个子路径的绘制
            path2.StartFigure();
            //添加弧线
            path2.AddArc(0, 90, 100, 50, 0.0f, 180.0f);

            //在封闭当前子路径的情况下开始第三个子路径的绘制
            path2.CloseFigure();
            path2.AddArc(0, 120, 100, 50, 0.0f, 180.0f);

            //绘制子路径
            graphics.DrawPath(pen, path2);
        }

        private void Path_GetSubPath_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen bluePen = new Pen(Color.Blue, 3);
            GraphicsPath path = new GraphicsPath();
            // 字路径1
            path.AddRectangle(new Rectangle(20, 20, 60, 30));
            // 字路径2
            path.AddLine(100, 20, 160, 50);
            path.AddArc(180, 20, 60, 30, 0.0f, 180.0f);
            // 字路径3
            path.AddRectangle(new Rectangle(260, 20, 60, 30));
            // 字路径4
            path.AddLine(340, 20, 400, 50);
            path.AddArc(340, 20, 60, 30, 0.0f, 180.0f);
            path.CloseFigure();
            // 字路径5
            path.AddRectangle(new Rectangle(420, 20, 60, 30));
            //绘制路径
            graphics.DrawPath(bluePen, path);

            // 建立路径描述对象iterator
            GraphicsPathIterator iterator = new GraphicsPathIterator(path);
            GraphicsPath subpath = new GraphicsPath();
            bool isClosed = false;
            int count = 0;
            //连续调用两次NextSubpath,获取子路径
            //将路径的当前位置移动到1
            count = iterator.NextSubpath(subpath, out isClosed);
            //将路径的当前位置移动到2
            count = iterator.NextSubpath(subpath, out isClosed);

            //在第二行绘制提取的子路径
            graphics.TranslateTransform(0, 50);
            graphics.DrawPath(bluePen, subpath);

            //复位所有的位置移动信息
            iterator.Rewind();
            count = iterator.NextSubpath(subpath, out isClosed);
            //在第三行绘制新抽取的子路径
            graphics.TranslateTransform(0, 50);
            Pen redPen = new Pen(Color.Red, 3);
            graphics.DrawPath(redPen, subpath);

            //连续调用两次NextSubpath，以获取子路径的定义点信息
            int start = 0;
            int end = 0;
            string msg = string.Empty;
            //复位所有的位置移动信息
            iterator.Rewind();
            count = iterator.NextSubpath(out start, out end, out isClosed);
            //保存位置索引信息
            msg = string.Format(
                "第一次移动子路径的定义点起止位置为{0}\t和\t{1}\n", start, end);
            count = iterator.NextSubpath(out start, out end, out isClosed);
            msg += string.Format(
                "第二次移动子路径的定义点起止位置为{0}\t和\t{1}\n", start, end);

            //绘制子路径的定义点位置索引信息
            FontFamily fontFamily = new FontFamily("宋体");
            Font font = new Font(fontFamily, 12);
            graphics.TranslateTransform(0, 60);
            graphics.DrawString(msg, font, Brushes.Black, new PointF(0, 0));
        }

        private void Path_GetPoints_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //创建路径对象
            GraphicsPath path = new GraphicsPath();
            //添加直线
            path.AddLine(20, 100, 150, 120);
            //添加矩形
            path.AddRectangle(new Rectangle(40, 30, 20, 60));
            //添加椭圆
            path.AddEllipse(new Rectangle(70, 30, 100, 40));
            //添加曲线　
            Point[] points = new Point[]
		{
			new Point(300, 40),
			new Point(350, 60),
			new Point(300, 80),
			new Point(300, 100),
			new Point(350, 150)
		};
            path.AddCurve(points, 5);

            //绘制路径
            Pen pen = new Pen(Color.Blue);
            graphics.DrawPath(pen, path);

            // 获取定义路径的点总数
            int count = path.PointCount;
            //绘制点定义路径的点
            SolidBrush brush = new SolidBrush(Color.Red);
            for (int j = 0; j < count; ++j)
            {
                graphics.FillEllipse(
                    brush,
                    path.PathPoints[j].X - 3.0f,
                    path.PathPoints[j].Y - 3.0f,
                    6.0f,
                    6.0f);
            }
            /*另外一一种遍历数组的方式
            foreach( PointF x in path.PathPoints)
                graphics.FillEllipse(
                    brush, 
                    x.X - 3.0f, 
                    x.Y - 3.0f,
                    6.0f,
                    6.0f);
            */
        }

        private void Path_PathData_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //曲线的定义点
            Point[] points = new Point[]
		{
			new Point(40, 60), 
			new Point(50, 70), 
			new Point(30, 90)
		};

            Pen pen = new Pen(Color.Red, 2);
            GraphicsPath path = new GraphicsPath();
            //弧线
            path.AddArc(175, 50, 50, 50, 0.0f, -180.0f);
            //直线
            path.AddLine(100, 0, 250, 20);
            path.StartFigure();
            //直线
            path.AddLine(50, 20, 5, 90);
            //曲线
            path.AddCurve(points, 3);
            path.AddLine(50, 150, 150, 180);
            path.CloseAllFigures();
            //绘制路径
            graphics.DrawPath(pen, path);
            PathData pathData = new PathData();
            //获取PathData属性值
            pathData = path.PathData;
            SolidBrush brush = new SolidBrush(Color.Red);

            //绘制定义点
            foreach (PointF i in pathData.Points)
                graphics.FillEllipse(Brushes.Black,
                    i.X - 5.0f, i.Y - 5.0f, 10.0f, 10.0f);
            //输出每一个路径定义点的类型
            int index = 1;
            FontFamily fontFamily = new FontFamily("宋体");
            Font font = new Font(fontFamily, 12);
            graphics.TranslateTransform(path.GetBounds().Width + 10, 0);
            foreach (PathPointType ii in pathData.Types)
            {
                string msg = string.Format("第{0}点的类型为:\t{1}",
                    index.ToString(), ii.ToString());
                graphics.DrawString(msg,
                    font, Brushes.Black, new PointF(0, index * font.Height));
                index++;
            }
        }

        private void Path_ViewPointFLAG_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);
            graphics.ScaleTransform(0.8f, 0.8f);


            SolidBrush brush = new SolidBrush(Color.Red);
            //创建一个具有四个子路径的路径
            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(new Rectangle(20, 20, 60, 30));
            path.AddLine(100, 20, 160, 50);
            path.AddArc(180, 20, 60, 30, 0, 180);
            path.AddRectangle(new Rectangle(260, 20, 60, 30));
            path.AddLine(340, 20, 400, 50);
            path.AddArc(340, 20, 60, 30, 0, 180);
            path.CloseAllFigures();
            //填充路径
            graphics.FillPath(brush, path);

            //将路径的标记信息传入GraphicsPathIterator对象
            GraphicsPathIterator iterator = new GraphicsPathIterator(path);

            //获取标记点信息
            int start = 0;
            int end = 0;
            int count = 0;
            //获取第一个标记区间
            count = iterator.NextMarker(out start, out end);
            //为点坐标、类型分配空间
            PointF[] points = new PointF[count];
            byte[] types = new byte[count];
            //从iterator复制信息
            iterator.CopyData(ref points, ref types, start, end);
            //根据复制的信息新创建一个路径
            GraphicsPath pathnew = new GraphicsPath(points, types);

            //在新位置绘制路径的定义点
            graphics.TranslateTransform(0, 60);
            for (int j = 0; j < count; ++j)
                graphics.FillEllipse(Brushes.Black, points[j].X - 2.0f,
                    points[j].Y - 2.0f, 4.0f, 4.0f);

            //填充新创建的路径
            graphics.TranslateTransform(0, 60);
            graphics.FillPath(brush, pathnew);
            graphics.TranslateTransform(0, 60);

            //输出所有的标记点信息
            string msg = string.Empty;
            for (int j = 0; j < count; ++j)
            {
                msg += string.Format("第{0}的信息:X={1:F2}\tY={2:F2}\t类型={3}\n",
                    j, points[j].X, points[j].Y, types[j].ToString());
            }

            //绘制字符串
            FontFamily fontFamily = new FontFamily("宋体");
            Font font = new Font(fontFamily, 12, FontStyle.Regular, GraphicsUnit.Pixel);
            graphics.DrawString(msg, font, Brushes.Black, new PointF(0, 0));

        }

        private void Path_SubPathRange_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush brush = new SolidBrush(Color.Red);
            //创建一个具有五个子路径的路径
            GraphicsPath path = new GraphicsPath();
            /*************path.SetMarkers();**************/
            //添加第一个子路径
            path.AddRectangle(new Rectangle(20, 20, 60, 30));

            //添加第二个子路径
            path.AddLine(100, 20, 160, 50);
            //第二个标记将第二个子路径从中央截断
            path.SetMarkers();
            path.AddArc(180, 20, 60, 30, 0, 180);

            //添加第三个子路径
            path.AddRectangle(new Rectangle(260, 20, 60, 30));
            //第三个标记
            path.SetMarkers();

            //添加第四个子路径
            path.AddLine(340, 20, 400, 50);
            path.AddArc(340, 20, 60, 30, 0, 180);

            //填充路径
            graphics.FillPath(brush, path);

            //将路径的标记信息传入GraphicsPathIterator对象
            GraphicsPathIterator iterator = new GraphicsPathIterator(path);
            int d = iterator.SubpathCount;
            //获取标记点信息
            int start;
            int end;
            int count;
            //移到第二个标记
            count = iterator.NextMarker(out start, out end);
            //移到第三个标记
            count = iterator.NextMarker(out start, out end);
            //为点坐标、类型分配空间
            PointF[] points = new PointF[count];
            byte[] types = new byte[count];

            //从iterator复制信息
            iterator.CopyData(ref points, ref types, start, end);
            //根据复制的信息新创建一个路径
            GraphicsPath pathnew = new GraphicsPath(points, types);

            //在新位置绘制标记点
            graphics.TranslateTransform(0, 60);
            for (int j = 0; j < count; ++j)
                graphics.FillEllipse(Brushes.Black,
                    points[j].X - 2.0f, points[j].Y - 2.0f,
                    4.0f,
                    4.0f);

            //填充新创建的路径
            graphics.TranslateTransform(0, 60);
            graphics.FillPath(brush, pathnew);

            //输出所有的标记点信息
            string msg = string.Empty;
            for (int j = 0; j < count; ++j)
            {
                msg += string.Format("第{0}点的信息:X={1:F2}\tY={2:F2} \t类型＝{3:F2}\n",
                    j, points[j].X, points[j].Y, types[j].ToString());
            }

            FontFamily fontFamily = new FontFamily("宋体");
            Font font = new Font(fontFamily, 12, FontStyle.Regular, GraphicsUnit.Pixel);
            //绘制字符串
            graphics.TranslateTransform(0, 60);
            graphics.DrawString(msg, font, Brushes.Black, new PointF(0, 0));
        }

        private void Path＿Flatten_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //曲线定义点
            Point[] pts = new Point[]
		{
			new Point(20,50), 
			new Point(60,70), 
			new Point(80,10), 
			new Point(120,50)
		};

            GraphicsPath path = new GraphicsPath();
            path.AddCurve(pts, 4);
            path.AddEllipse(160, 10, 150, 80);
            path.AddBezier(20, 100, 20, 150, 50, 80, 100, 60);

            //按照默认的方式绘制路径
            Pen pen = new Pen(Color.Black, 3);
            graphics.DrawPath(pen, path);
            //获取路径点信息
            PathData pathData = new PathData();
            pathData = path.PathData;

            // 绘制路径定义点
            SolidBrush brush = new SolidBrush(Color.Red);
            for (int j = 0; j < path.PointCount; ++j)
            {
                graphics.FillEllipse(brush, pathData.Points[j].X - 3.0f,
                    pathData.Points[j].Y - 3.0f, 6.0f, 6.0f);
            }

            //绘图平面下移100个单位 
            graphics.TranslateTransform(0, 120);
            //进行曲线转  
            path.Flatten(new Matrix(), 14.0f);
            pen.Color = Color.Green;
            //绘制转换后的路径  
            graphics.DrawPath(pen, path);
        }

        private void Path_Warp_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            // 创建一个全部由线条组成的路径
            PointF[] points = new PointF[]
		{
			new PointF(20.0f, 60.0f),
			new PointF(30.0f, 90.0f),
			new PointF(15.0f, 110.0f),
			new PointF(15.0f, 145.0f),
			new PointF(55.0f, 145.0f),
			new PointF(55.0f, 110.0f),
			new PointF(40.0f, 90.0f),
			new PointF(50.0f, 60.0f)
		};

            GraphicsPath path = new GraphicsPath();
            path.AddLines(points);
            path.CloseFigure();

            // 绘制扭曲前的路径
            Pen bluePen = new Pen(Color.Blue, 3);
            graphics.DrawPath(bluePen, path);

            // 定义放置路径的源矩形
            RectangleF srcRect = new RectangleF(10.0f, 50.0f, 50.0f, 100.0f);
            //定义矩形映射的目标点
            PointF[] destPts = new PointF[]
		{
			new PointF(220.0f, 10.0f),
			new PointF(280.0f, 10.0f),
			new PointF(100.0f, 150.0f),
			new PointF(300.0f, 150.0f)
		};

            //扭曲矩形
            path.Warp(destPts, srcRect);
            // 绘制扭曲后的路径
            graphics.DrawPath(bluePen, path);

            // 绘制源矩形和目标的多边形
            Pen blackPen = new Pen(Color.Black, 1);
            graphics.DrawRectangle(blackPen,
                srcRect.X, srcRect.Y, srcRect.Width, srcRect.Height);
            graphics.DrawLine(blackPen, destPts[0], destPts[1]);
            graphics.DrawLine(blackPen, destPts[0], destPts[2]);
            graphics.DrawLine(blackPen, destPts[1], destPts[3]);
            graphics.DrawLine(blackPen, destPts[2], destPts[3]);
        }

        private void Path_Transform_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            GraphicsPath path = new GraphicsPath();
            //添加一个矩形子路径   
            path.AddRectangle(new Rectangle(40, 10, 200, 50));
            //绘制坐标变换前的路径
            graphics.DrawPath(new Pen(Color.Blue, 4), path);

            //旋转路径
            Matrix matrix = new Matrix();
            matrix.Rotate(15.0f);
            path.Transform(matrix);
            //绘制进行坐标变换后的路径
            graphics.DrawPath(new Pen(Color.Red, 4), path);
        }

        private void Path_Widen_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen bluePen = new Pen(Color.Blue, 1);
            Pen greenPen = new Pen(Color.Green, 10);
            //定义曲线
            PointF[] points =
		{
			new PointF(10.0f, 10.0f),
			new PointF(130.0f, 90.0f),
			new PointF(140.0f, 60.0f),
			new PointF(60.0f, 90.0f)
		};

            GraphicsPath path = new GraphicsPath();
            //添加四条曲线
            path.AddClosedCurve(points, 4);

            //复制三个相同的路径进行轮廓拓宽处理
            GraphicsPath path2 = new GraphicsPath();
            GraphicsPath path3 = new GraphicsPath();
            GraphicsPath path4 = new GraphicsPath();
            path2 = (GraphicsPath)path.Clone();
            path3 = (GraphicsPath)path.Clone();
            path4 = (GraphicsPath)path.Clone();

            //使用宽度为10的画笔绘制路径
            graphics.DrawPath(new Pen(Color.Blue, 10), path);
            RectangleF rect = path.GetBounds();

            //使用绿色画笔拓宽路径轮廓
            path2.Widen(greenPen);
            //绘图平面右移，绘制拓宽的路径
            graphics.TranslateTransform(rect.Width + 10, 0);
            graphics.DrawPath(bluePen, path2);

            //下移
            graphics.TranslateTransform(-rect.Width, rect.Height);
            //使用间断线风格的绿色画笔拓宽路径
            greenPen.DashStyle = DashStyle.Dash;
            path3.Widen(greenPen);
            //填充路径
            graphics.FillPath(Brushes.Red, path3);

            //对画笔进行缩放变换 
            Pen pentmp = new Pen(Color.Blue);
            pentmp.ScaleTransform(3.0f, 20.0f);
            path4.Widen(pentmp);
            //绘图平面右移
            graphics.TranslateTransform(rect.Width, 0);
            graphics.DrawPath(bluePen, path4);

        }

        private void Path_WidenDemo_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen bluePen = new Pen(Color.Blue, 1);
            Pen greenPen = new Pen(Color.Green, 20);
            GraphicsPath path = new GraphicsPath();
            //添加一条直线
            path.AddLine(10, 20, 100, 20);
            GraphicsPath path2 = (GraphicsPath)path.Clone();

            PathData pathData = new PathData();
            PathData pathData2 = new PathData();

            pathData = path.PathData;
            int num1 = path.PointCount;

            //保存路径的定义点信息
            string msg = string.Empty;
            for (int i = 0; i < num1; i++)
            {

                msg += string.Format("点{0}的坐标分别为：X={1:F2}\tY={2:F2}\n",
                    i, pathData.Points[i].X, pathData.Points[i].Y);
            }
            //绘制路径
            graphics.DrawPath(new Pen(Color.Blue), path);

            //使用绿色画笔拓宽路径轮廓
            path2.Widen(greenPen);
            pathData2 = path2.PathData;
            int num2 = path2.PointCount;

            //绘图平面右移，绘制拓宽的路径
            RectangleF rect = path.GetBounds();
            graphics.TranslateTransform(rect.Width * 2, 0);
            graphics.DrawPath(bluePen, path2);
            graphics.ResetTransform();
            //保存拓宽后路径的定义点信息
            string msg2 = string.Empty;
            for (int i = 0; i < num2; i++)
            {
                msg2 += string.Format("拓宽后的路径点{0}的坐标分别为：X={1:F2}\tY={2:F2}\n",
                    i, pathData2.Points[i].X, pathData2.Points[i].Y);
            }

            //输出路径拓宽前后的定义点坐标位置信息
            FontFamily fontFamily = new FontFamily("宋体");
            Font font = new Font(fontFamily, 12, FontStyle.Regular, GraphicsUnit.Pixel);
            graphics.TranslateTransform(0, 120);
            graphics.DrawString(msg, font, Brushes.Black, new PointF(0, 0));
            graphics.TranslateTransform(0, font.Height * (num1 + 1));
            graphics.DrawString(msg2, font, Brushes.Black, new PointF(0, 0));

        }

        private void Region＿FromPath_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);
            //设定文本输出质量
            graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            FontFamily fontFamily = new FontFamily("楷体_GB2312");
            //创建路径区域
            GraphicsPath path = new GraphicsPath();

            //向区域中追加文本
            path.AddString("文字区域", fontFamily,
                (int)FontStyle.Regular, 100.0f, new Point(0, 0), new StringFormat());

            Pen pen = new Pen(Color.Red);
            //绘制路径
            graphics.DrawPath(pen, path);
            graphics.TranslateTransform(0, 80);
            //从路径中构造区域
            Region region = new Region(path);
            //填充区域	
            graphics.FillRegion(Brushes.Red, region);
        }

        private void Region_Calculate_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            FontFamily fontFamily = new FontFamily("宋体");
            Font font = new Font(fontFamily, 16, FontStyle.Regular, GraphicsUnit.Pixel);

            SolidBrush solidBrush2 = new SolidBrush(Color.Red);
            SolidBrush solidBrush = new SolidBrush(Color.Green);
            Pen pen = new Pen(Color.Cyan);

            //定义多边形的端点坐标
            Point[] points = new Point[]
		{
			new Point(75, 0), 
			new Point(100, 50), 
			new Point(150, 50), 
			new Point(112, 75),
			new Point(150, 150), 
			new Point(75, 120), 
			new Point(10, 150), 
			new Point(37, 75), 
			new Point(0, 50), 
			new Point(50, 50),
			new Point(75, 0)
		};

            //创建路径并添加线条
            GraphicsPath path = new GraphicsPath();
            path.AddLines(points);

            //缩小路径
            Matrix matrix = new Matrix();
            matrix.Scale(0.5f, 0.5f);
            path.Transform(matrix);

            //获取路径所占的矩形区域
            RectangleF tmp = path.GetBounds();

            //定义区域2
            RectangleF rect = new RectangleF(0, 10, tmp.Width, 50);
            //计算文本信息输出区域
            RectangleF textout = new RectangleF(0, tmp.Height, tmp.Width, font.Height * 2);

            //设置文本输出格式：水平居中、垂直靠下
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Far;

            //填充路径 
            graphics.FillPath(solidBrush2, path);

            graphics.TranslateTransform(tmp.Width + 10, 0);
            //填充矩形 
            graphics.FillRectangle(solidBrush, rect);

            //从路径中创建区域
            Region region = new Region(path);

            //求交集
            region.Intersect(rect);
            graphics.TranslateTransform(tmp.Width + 10, 0);
            //填充交集
            graphics.FillRegion(solidBrush2, region);
            graphics.DrawString("交集", font, Brushes.Black, textout, format);
            //绘制路径所占的矩形区域
            graphics.DrawRectangle(pen, tmp.X, tmp.Y, tmp.Width, tmp.Height);

            //求并集
            Region region2 = new Region(path);
            region2.Union(rect);
            graphics.TranslateTransform(tmp.Width + 10, 0);
            graphics.FillRegion(solidBrush2, region2);
            graphics.DrawString("并集", font, solidBrush, textout, format);
            //绘制路径所占的矩形区域
            graphics.DrawRectangle(pen, tmp.X, tmp.Y, tmp.Width, tmp.Height);

            //换行输出区域运算结果
            graphics.TranslateTransform(-(tmp.Width + 10) * 3, tmp.Height + textout.Height);

            //求异并集
            Region region3 = new Region(path);
            region3.Xor(rect);
            //填充异并集
            graphics.FillRegion(solidBrush2, region3);
            graphics.DrawString("异并集", font, Brushes.Black, textout, format);
            //绘制路径所占的矩形区域
            graphics.DrawRectangle(pen, tmp.X, tmp.Y, tmp.Width, tmp.Height);

            //求补集
            Region region4 = new Region(path);
            region4.Complement(rect);
            graphics.TranslateTransform(tmp.Width + 10, 0);
            //填充补集
            graphics.FillRegion(solidBrush2, region4);
            graphics.DrawString("补集", font, Brushes.Black, textout, format);
            //绘制路径所占的矩形区域
            graphics.DrawRectangle(pen, tmp.X, tmp.Y, tmp.Width, tmp.Height);

            //求排斥集
            Region region5 = new Region(path);
            region5.Exclude(rect);
            graphics.TranslateTransform(tmp.Width + 10, 0);
            //填排斥集
            graphics.FillRegion(solidBrush2, region5);
            graphics.DrawString("排斥集", font, Brushes.Black, textout, format);
            graphics.DrawRectangle(pen, tmp.X, tmp.Y, tmp.Width, tmp.Height);
        }

        private void Region_GetRects_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush solidBrush = new SolidBrush(Color.Red);
            Pen pen = new Pen(Color.Black);
            GraphicsPath path = new GraphicsPath();
            Matrix matrix = new Matrix();

            //从路径中创建区域
            path.AddEllipse(10, 0, 80, 120);
            Region pathRegion = new Region(path);
            //填充区域
            graphics.FillRegion(solidBrush, pathRegion);

            //获取路径的矩形组成集信息（不使用变换）
            RectangleF[] rects = pathRegion.GetRegionScans(matrix);
            //绘制平面右移，以绘制矩形集中所有的矩形
            graphics.TranslateTransform(90, 0);
            foreach (RectangleF rect in rects)
                graphics.DrawRectangle(pen,
                    rect.X, rect.Y, rect.Width, rect.Height);

            //实施变换
            matrix.Scale(1.0f, 0.75f);
            matrix.Shear(0.2f, 0.3f);
            //获取路径的矩形组成集信息（使用变换）
            rects = pathRegion.GetRegionScans(matrix);

            //绘制平面右移，以绘制变换后的矩形集
            graphics.TranslateTransform(90, 0);
            foreach (RectangleF rect in rects)
                graphics.DrawRectangle(pen, rect.X, rect.Y, rect.Width, rect.Height);

        }

        private void Form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //试用该段程序时，请将一句代码注释掉
            return;
            //如果鼠标左键未按下，不做处理 
            if (e.Button != MouseButtons.Left)
                return;

            Graphics graphics = this.CreateGraphics();
            //定义路径曲线	
            PointF[] points = new PointF[]
		{
			new PointF(20.0f, 20.0f),
			new PointF(160.0f, 100.0f),
			new PointF(140.0f, 60.0f),
			new PointF(60.0f, 100.0f)
		};

            //构造路径并增加曲线
            GraphicsPath path = new GraphicsPath();
            path.AddClosedCurve(points);
            //放大路径
            Matrix matrix = new Matrix();
            matrix.Scale(2.0f, 1.0f);
            path.Transform(matrix);

            //从路径中创建区域
            Region pathRegion = new Region(path);
            graphics.FillRegion(Brushes.Blue, pathRegion);

            //将当前鼠标位置进行测试
            Point test = new Point(e.X, e.Y);
            //如果在区域内，不处理
            if (pathRegion.IsVisible(test, graphics))
                return;

            //如果在区域外，绘制圆点
            SolidBrush brush = new SolidBrush(Color.Black);
            graphics.FillEllipse(brush, test.X - 4, test.Y - 4, 8, 8);
        }

        private void Transform_Click(object sender, System.EventArgs e)
        {
            Graphics myGraphics = this.CreateGraphics();
            myGraphics.Clear(Color.White);

            SolidBrush mySolidBrush1 = new SolidBrush(Color.Blue);
            SolidBrush mySolidBrush2 = new SolidBrush(Color.FromArgb(155, Color.Chocolate));
            GraphicsPath myGraphicsPath = new GraphicsPath();
            Rectangle myRect = new Rectangle(60, 60, 60, 60);
            //在路径中添加矩形
            myGraphicsPath.AddRectangle(myRect);
            //填充路径
            myGraphics.FillPath(mySolidBrush1, myGraphicsPath);

            // 进行坐标变换
            Matrix myPathMatrix = new Matrix();
            //水平方向扩大两倍，垂直方向保持不变
            myPathMatrix.Scale(2, 1);
            myPathMatrix.Rotate(30.0f);
            //对路径实话坐标变换
            myGraphicsPath.Transform(myPathMatrix);

            //填充变换后的路径
            myGraphics.FillPath(mySolidBrush2, myGraphicsPath);
        }

        private void TranslateTransform_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //装入图片
            Bitmap image = new Bitmap("nemo.bmp");
            //定义图片的显示区域
            Rectangle rect = new Rectangle(0, 0, 110, 70);
            for (int i = 0; i < 10; i++)
            {
                //显示图片
                graphics.DrawImage(image, rect);
                //绘图平面右移，每次沿水平方面右移110个像素
                graphics.TranslateTransform(110, 0);

            }

        }

        private void RotateTransform_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //装入图片
            Bitmap image = new Bitmap("nemo.bmp");

            //获取当前窗口的中心点
            Rectangle rect = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            PointF center = new PointF(rect.Width / 2, rect.Height / 2);

            float offsetX = 0;
            float offsetY = 0;
            offsetX = center.X - image.Width / 2;
            offsetY = center.Y - image.Height / 2;
            //构造图片显示区域:让图片的中心点与窗口的中心点一致
            RectangleF picRect = new RectangleF(offsetX, offsetY, image.Width, image.Height);
            PointF Pcenter = new PointF(picRect.X + picRect.Width / 2,
                picRect.Y + picRect.Height / 2);

            //让图片绕中心旋转一周
            for (int i = 0; i < 361; i += 10)
            {
                // 绘图平面以图片的中心点旋转
                graphics.TranslateTransform(Pcenter.X, Pcenter.Y);
                graphics.RotateTransform(i);
                //恢复绘图平面在水平和垂直方向的平移
                graphics.TranslateTransform(-Pcenter.X, -Pcenter.Y);
                //绘制图片并延时
                graphics.DrawImage(image, picRect);
                Thread.Sleep(100);
                //重置绘图平面的所有变换
                graphics.ResetTransform();
            }
        }

        private void DrawWatch_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Rectangle clientrect = new Rectangle(0, 0,
                this.ClientSize.Width, this.ClientSize.Height);

            //设置路码表的高和宽
            float WIDTH = clientrect.Width / 2;
            float HEIGHT = clientrect.Height / 2;

            //设置文本输出外观
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            FontFamily fontFamily = new FontFamily("Times New Roman");
            Font font = new Font(fontFamily, 14, FontStyle.Bold, GraphicsUnit.Pixel);

            //将绘图平面的坐标原点移到窗口中心
            graphics.TranslateTransform(WIDTH / 2, HEIGHT / 2);
            //绘制仪表盘
            graphics.FillEllipse(Brushes.Black,
                HEIGHT / -2, HEIGHT / -2, HEIGHT, HEIGHT);
            //输出文本
            graphics.DrawString("公里/小时", font, Brushes.Green,
                new PointF(-26, HEIGHT / -4 - font.Height));

            //绘制刻度标记
            graphics.RotateTransform(225);
            for (int x = 0; x < 55; x++)
            {
                graphics.FillRectangle(Brushes.Green,
                    -2, (HEIGHT / 2 - 2) * -1, 3, 15);
                graphics.RotateTransform(5);
            }

            //重置绘图平面的坐标变换
            graphics.ResetTransform();

            graphics.TranslateTransform(WIDTH / 2, HEIGHT / 2);
            graphics.RotateTransform(225);
            int sp = 0;
            string tmp = string.Empty;
            //绘制刻度值(整数类)
            for (int x = 0; x < 7; x++)
            {
                tmp = string.Format("{0}", sp);

                //绘制红色刻度
                graphics.FillRectangle(Brushes.Red, -3, (HEIGHT / 2 - 2) * -1, 6, 25);
                //绘制数值
                graphics.DrawString(tmp, font, Brushes.Green, new PointF(tmp.Length * (-6),
                    (HEIGHT / -2) + 25));
                //旋转45度
                graphics.RotateTransform(45);
                sp += 20;
            }

            //重置绘图平面的坐标变换
            graphics.ResetTransform();
            graphics.TranslateTransform(WIDTH / 2, HEIGHT / 2);

            //绘制指针在30公里/秒的情形
            float angle = 30 * 2.25f + 225;
            graphics.RotateTransform((float)angle);

            Pen pen = new Pen(Color.Blue, 14);
            //设置线帽
            pen.EndCap = LineCap.ArrowAnchor;
            pen.StartCap = LineCap.RoundAnchor;
            //画指针
            graphics.DrawLine(pen, new PointF(0, 0), new PointF(0, (-1) * (HEIGHT / 2.75F)));

            graphics.ResetTransform();
            graphics.TranslateTransform(WIDTH / 2, HEIGHT / 2);
            //绘制中心点
            graphics.FillEllipse(Brushes.Black, -6, -9, 14, 14);
            graphics.FillEllipse(Brushes.Red, -7, -7, 14, 14);

            //绘制速度极限标记
            pen.Width = 4;
            pen.Color = Color.Black;
            pen.EndCap = LineCap.Round;
            pen.StartCap = LineCap.Flat;
            graphics.DrawLine(pen, new PointF(HEIGHT / 15.75F, HEIGHT / 3.95F),
                new PointF(HEIGHT / 10.75F, HEIGHT / 5.2F));
            pen.Color = Color.Red;
            graphics.DrawLine(pen, new PointF(HEIGHT / 15.75F, HEIGHT / 3.95F),
                new PointF(HEIGHT / 15.75F, HEIGHT / 4.6F));
        }

        private void ScaleTransform_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Rectangle clientrect = new Rectangle(0, 0,
                this.ClientSize.Width, this.ClientSize.Height);
            //获取当前窗口的中心点
            float width = clientrect.Width / 2;
            float height = clientrect.Height / 2;
            PointF center = new PointF(width, height);

            //设置矩形初始大小为30*30
            float offsetX = center.X - 15;
            float offsetY = center.Y - 15;

            //构造矩形的缩放区域:让矩形的中心点与窗口的中心点一致
            RectangleF rotateRect = new RectangleF(offsetX, offsetY, 30, 30);
            PointF Pcenter = new PointF(rotateRect.X + rotateRect.Width / 2,
                rotateRect.Y + rotateRect.Height / 2);

            //设置初始缩放倍数
            int scale = 1;
            //对矩形rotateRect旋转360度并不断放大矩形
            for (int i = 0; i < 360; i += 60)
            {
                // 绘图平面以图片的中心点旋转
                graphics.TranslateTransform(Pcenter.X, Pcenter.Y);
                //在水平和垂直方向上同时扩大矩形
                graphics.ScaleTransform(scale, scale);
                graphics.RotateTransform(i);
                //恢复绘图平面在水平和垂直方向的平移
                graphics.TranslateTransform(-Pcenter.X, -Pcenter.Y);
                //绘制矩形并延时
                graphics.DrawRectangle(Pens.Black,
                    rotateRect.X, rotateRect.Y, rotateRect.Width, rotateRect.Height);
                Thread.Sleep(100);
                //重置绘图平面的所有变换
                graphics.ResetTransform();
                scale++;
            }
        }

        private void RectScale_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Rectangle clientrect = new Rectangle(0, 0,
                this.ClientSize.Width, this.ClientSize.Height);
            //获取当前窗口的中心点
            float width = clientrect.Width / 2;
            float height = clientrect.Height / 2;
            PointF center = new PointF(width, height);

            //设置矩形初始大小为30*30
            float offsetX = center.X - 15;
            float offsetY = center.Y - 15;

            //构造矩形的缩放区域:让矩形的中心点与窗口的中心点一致
            RectangleF rotateRect = new RectangleF(offsetX, offsetY, 30, 30);
            PointF Pcenter = new PointF(rotateRect.X + rotateRect.Width / 2,
                rotateRect.Y + rotateRect.Height / 2);

            //设置初始缩放倍数
            int scale = 0;
            //对矩形rotateRect旋转360度并不断放大矩形
            for (int i = 0; i < 361; i += 60)
            {
                // 绘图平面以图片的中心点旋转
                graphics.TranslateTransform(Pcenter.X, Pcenter.Y);
                //在水平和垂直方向上同时增加矩形的宽度和高度
                rotateRect.Inflate(scale * 15, scale * 15);
                graphics.RotateTransform(i);
                //恢复绘图平面在水平和垂直方向的平移
                graphics.TranslateTransform(-Pcenter.X, -Pcenter.Y);
                //绘制图片并延时
                graphics.DrawRectangle(Pens.Black,
                    rotateRect.X, rotateRect.Y, rotateRect.Width, rotateRect.Height);
                Thread.Sleep(100);
                //重置对矩形大小的所有变换
                graphics.ResetTransform();
                rotateRect.Inflate(-scale * 15, -scale * 15);
                scale++;
            }

        }

        private void FontRotate_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            FontFamily fontFamily = new FontFamily("宋体");
            Font myFont = new Font(fontFamily, 20, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush redBrush = new SolidBrush(Color.Red);

            //设置文本输出区域
            RectangleF layoutRect = new RectangleF(myFont.Height, myFont.Height,
                this.ClientSize.Width / 2, this.ClientSize.Height / 2);

            StringFormat format = new StringFormat();
            //设置文本输出格式
            format.Alignment = StringAlignment.Near;
            format.LineAlignment = StringAlignment.Center;
            //将文本的输出起点设置成窗口的中心
            graphics.TranslateTransform(layoutRect.Width, layoutRect.Height);

            //在旋转时每隔30度输出文本
            for (int i = 0; i < 360; i += 30)
            {
                //旋转绘图平面
                graphics.RotateTransform(i);
                graphics.DrawString(" 旋转字体", myFont, redBrush,
                    layoutRect, format);
                //恢复所做的旋转
                graphics.RotateTransform(-i);
            }

        }

        private void MirrorText_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);
            SolidBrush redBrush = new SolidBrush(Color.Red);

            //构造字体，用于镜像文本输出
            FontFamily fontFamily = new FontFamily("楷体_GB2312_GB2312");
            Font myFont = new Font(fontFamily,
                48, FontStyle.Regular, GraphicsUnit.Pixel);
            //构造英文字体，用于演示文本的输出方向
            FontFamily fontFamily2 = new FontFamily("Courier New");
            Font myFont2 = new Font(fontFamily2,
                16, FontStyle.Regular, GraphicsUnit.Pixel);

            //设置文本输出区域
            RectangleF layoutRect = new RectangleF(myFont.Height, myFont.Height,
                this.ClientSize.Width / 2, this.ClientSize.Height / 2);

            StringFormat format = new StringFormat();

            //设置文本输出时精确位置
            //行距－下行部分　(设计单位)
            float ascent = fontFamily.GetLineSpacing(FontStyle.Regular) -
                fontFamily.GetCellDescent(FontStyle.Regular);
            //行距－上行部分　(设计单位)
            float ascent2 = fontFamily.GetLineSpacing(FontStyle.Regular) -
                fontFamily.GetCellAscent(FontStyle.Regular);

            //将上、下部距离的设计单位转换成像素单位
            float ascentPixel = myFont.Size *
                ascent / (fontFamily.GetEmHeight(FontStyle.Regular));
            float ascentPixel2 = myFont.Size *
                ascent2 / (fontFamily.GetEmHeight(FontStyle.Regular));

            //绘图平面下移
            graphics.TranslateTransform(0, this.ClientSize.Height / 4);
            //绘制正常方向的文本
            graphics.DrawString("镜像输出", myFont, redBrush,
                new PointF(0, -myFont.Height + ascentPixel2), format);

            //绘图平面右移，演示当前文本输出文向
            graphics.TranslateTransform(200, 0);
            string msg = string.Empty;
            for (int i = 0; i < 3; i++)
            {
                msg = string.Format("Line {0}...........", i);
                graphics.DrawString(msg, myFont2, redBrush,
                    new PointF(0, myFont2.Height * i), format);
            }

            //恢复对绘图平面的右移
            graphics.TranslateTransform(-200, 0);

            //绘图平面在垂直方向倒置
            graphics.ScaleTransform(1, -1);
            //输出镜像文本
            graphics.DrawString("镜像输出", myFont, Brushes.Gray,
                new PointF(0, -ascentPixel), format);
            //绘图平面再次右移，演示当前文本输出文向
            graphics.TranslateTransform(200, 0);
            for (int i = 0; i < 3; i++)
            {
                msg = string.Format("Line {0}...........", i);
                graphics.DrawString(msg, myFont2, Brushes.Gray,
                    new PointF(0, myFont2.Height * i), format);
            }

            //重置在绘图平面上进行的所有变换：演示水平镜像文本输出
            graphics.ResetTransform();
            //绘图平面下移
            graphics.TranslateTransform(this.ClientSize.Width / 2,
                this.ClientSize.Height / 2 + myFont.Height * 2);
            //绘制正常方向的文本
            graphics.DrawString("镜像输出", myFont, redBrush,
                new PointF(0, 0), format);
            //绘图平面在水平方向倒置
            graphics.ScaleTransform(-1, 1);
            //输出水平镜像文本
            graphics.DrawString("镜像输出", myFont, Brushes.Gray,
                new PointF(0, 0), format);
        }


        private void Matrix_ListElements_Click_1(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush redBrush = new SolidBrush(Color.Red);
            FontFamily fontFamily = new FontFamily("楷体_GB2312_GB2312");
            Font myFont = new Font(fontFamily, 20,
                FontStyle.Regular, GraphicsUnit.Pixel);

            //进行平移变换	
            graphics.TranslateTransform(10, 10);
            graphics.TranslateTransform(20, 10);
            Matrix m = new Matrix(); ;
            m = graphics.Transform;
            //获取已经实施在绘图平面的坐标变换
            float[] x = m.Elements;
            int index = 0;
            string msg = string.Empty;

            //输出矩阵的每一个元素
            foreach (float i in x)
            {
                msg = string.Format("第{0}个矩阵元素为{1:F2}", index, i);
                graphics.DrawString(msg, myFont, redBrush,
                    new PointF(0, myFont.Height * index));
                index++;
            }

        }

        private void MatrixPos_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Blue, 4);
            Pen pen2 = new Pen(Color.Gray);

            FontFamily fontFamily = new FontFamily("宋体");
            Font myFont = new Font(fontFamily,
                20, FontStyle.Regular, GraphicsUnit.Pixel);

            //获取当前窗口的大小
            Rectangle rect = new Rectangle(0, 0,
                this.ClientSize.Width, this.ClientSize.Height);

            //设置定义椭圆的矩形
            Rectangle r = new Rectangle(-40, -65, 80, 130);
            Matrix matrix = new Matrix();
            graphics.TranslateTransform(rect.Width / 2, rect.Height / 2);
            //使用默认的旋转顺序(MatrixOrder.Prepend)
            graphics.RotateTransform(20);
            //获取对绘图平面已经进行的坐标变换
            matrix = graphics.Transform;
            //绘制椭圆
            graphics.DrawEllipse(pen, r);

            //使用MatrixOrder.Append旋转顺序
            graphics.ResetTransform();
            graphics.TranslateTransform(rect.Width / 2, rect.Height / 2);
            graphics.RotateTransform(20, MatrixOrder.Append);
            //使用红色画笔绘制另一个椭圆
            graphics.DrawEllipse(new Pen(Color.Red, 1), r);
            Matrix matrix2 = new Matrix();
            matrix2 = graphics.Transform;

            //重置坐标变换、以窗口中心点为原点绘制坐标轴
            graphics.ResetTransform();
            graphics.DrawLine(pen2, 0, rect.Height / 2,
                rect.Width, rect.Height / 2);
            graphics.DrawLine(pen2, rect.Width / 2,
                0, rect.Width / 2, rect.Height);

            string msg = string.Empty;
            //获取矩阵元素值
            float[] x = matrix.Elements;
            //输出矩阵元素值
            int i = 0;
            foreach (float element in x)
            {
                msg += string.Format("{0,8:F2}", element);
                //输出行向量
                if (i == 1 || i == 3 || i == 5)
                {
                    //垂直方向上下移一行
                    graphics.TranslateTransform(0, myFont.Height);
                    //graphics.DrawString (msg, myFont,Brushes.Black,
                    //	new PointF(0,0));
                    msg = string.Empty;
                }
                i++;
            }
        }

        private void Martrix_Invert_Click(object sender, System.EventArgs e)
        {
            Graphics myGraphics = this.CreateGraphics();
            myGraphics.Clear(Color.White);

            Pen myPen = new Pen(Color.Blue, 4);
            Matrix matrix = new Matrix(1.0f, 0.0f, 0.0f, 1.0f, 30.0f, 20.0f);
            //检查矩阵是否可逆？
            if (!matrix.IsInvertible)
            {
                MessageBox.Show("该矩形为不可逆矩形，无法演示");
                return;
            }
            myGraphics.Transform = matrix;
            for (int i = 0; i < 200; i++)
            {
                //计算逆矩形
                matrix.Invert();
                //对绘图平面进行坐标变换
                myGraphics.Transform = matrix;
                myGraphics.DrawRectangle(myPen, 35, 25, 200, 100);
            }
        }

        private void Matrix_Multiply_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush brush = new SolidBrush(Color.Blue);
            FontFamily fontFamily = new FontFamily("Arial");
            Font myFont = new Font(fontFamily,
                16, FontStyle.Regular, GraphicsUnit.Pixel);
            //加载图片
            Bitmap image = new Bitmap("jieba.bmp");

            //缩放
            Matrix matrix1 = new Matrix(0.80f, 0.0f, 0.0f, 0.8f, 0.0f, 0.0f);
            //位移
            Matrix matrix2 = new Matrix(1.0f, 0.0f, 0.0f, 1.0f, 20.0f, 10.0f);
            //从右上往左下翻转图片：X轴与Y轴对调
            Matrix matrix3 = new Matrix(0.0f, 1.0f, 1.0f, 0.0f, 0.0f, 0.0f);

            //第一次追加变换
            matrix1.Multiply(matrix2, MatrixOrder.Append);
            //第二次追加变换
            matrix1.Multiply(matrix3, MatrixOrder.Append);
            //进行复合变换
            graphics.Transform = matrix1;

            //绘制图片
            graphics.DrawImage(image, 0, 0);
            //获取已经作用在绘图平面上的坐标变换
            Matrix matrix = new Matrix();
            matrix = graphics.Transform;
            graphics.ResetTransform();
            //在新位置上查看变换矩阵信息
            graphics.TranslateTransform(image.Height, 0);

            //获取矩阵元素值
            float[] x = matrix.Elements;
            //输出每一个矩阵元素的值
            string msg = string.Empty;
            int i = 0;
            foreach (float element in x)
            {
                msg += string.Format("{0,6:F2}", element);
                //输出行向量
                if (i == 1 || i == 3 || i == 5)
                {
                    //垂直方向上下移一行
                    graphics.TranslateTransform(0, myFont.Height);
                    graphics.DrawString(msg, myFont, Brushes.Black,
                        new PointF(0, 0));
                    msg = string.Empty;
                }
                i++;
            }
        }

        private void Matrix_TransformPoints_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            Pen pen1 = new Pen(Color.Blue, 2);
            Pen pen2 = new Pen(Color.Red, 1);

            //定义构成曲线的点坐标
            Point[] points = new Point[]
		{
			new Point(50, 100), 
			new Point(100, 50),
			new Point(150, 125),
			new Point(200, 100),
			new Point(250, 125),
			};

            //绘制曲线(未使用变换时)
            graphics.DrawCurve(pen1, points);
            //绘制曲线定义点信息
            for (int i = 0; i < 5; i++)
            {
                graphics.FillEllipse(blueBrush,
                    points[i].X - 5, points[i].Y - 5, 10, 10);
            }

            //定义一个在竖直方向上缩放因子为0.5的矩阵
            Matrix matrix = new Matrix(1.0f, 0.0f, 0.0f, 0.5f, 0.0f, 0.0f);
            //对points数据中的每一个成员进行矩形运算
            matrix.TransformPoints(points);

            //绘制曲线(使用变换后)	
            graphics.DrawCurve(pen2, points);

            //再次绘制曲线定义点信息
            for (int i = 0; i < 5; i++)
            {
                graphics.FillEllipse(redBrush,
                    points[i].X - 5, points[i].Y - 5, 10, 10);
            }
        }

        private void Matrix_TransformPoints2_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //构造字体系列
            FontFamily fontFamily = new FontFamily("楷体_GB2312");

            SolidBrush redBrush = new SolidBrush(Color.Red);
            //设置文本输出质量
            graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            //创建路径区域
            GraphicsPath path = new GraphicsPath();
            //向区域中追加文本，字体大小为60
            path.AddString("文字特效", fontFamily, (int)FontStyle.Regular,
                60, new Point(0, 0), new StringFormat());

            //获取路径的点信息
            PointF[] dataPoints = path.PathPoints;
            //获取路径的点类型信息
            byte[] pTypes = path.PathTypes;

            //复制路径 
            GraphicsPath path2 = (GraphicsPath)path.Clone();

            //将文本在水平方向上缩小，在垂直方向上拉伸
            Matrix matrix = new Matrix(0.50f, 0.0f, 0.0f, 3.5f, 0.0f, 0.0f);

            //对points数据中的每一个成员进行矩形运算
            matrix.TransformPoints(dataPoints);
            //根据计算后的点重新构造路径
            GraphicsPath newpath = new GraphicsPath(dataPoints, pTypes);
            //填充路径
            graphics.FillPath(redBrush, newpath);

            //第二种特效
            Matrix matrix2 = new Matrix(0.6f, 0.5f, 0.20f, 1.5f, 160.0f, -40.0f);
            dataPoints = path2.PathPoints;
            //对所有的点进行计算
            matrix2.TransformPoints(dataPoints);
            //根据计算后的点重新构造路径
            GraphicsPath newpath2 = new GraphicsPath(dataPoints, pTypes);
            graphics.FillPath(redBrush, newpath2);
        }

        private void Matrix_TransformVectors_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Blue, 7);
            pen.EndCap = LineCap.ArrowAnchor;
            SolidBrush brush = new SolidBrush(Color.Blue);

            // 定义一个点和一个向量
            PointF[] point = new PointF[] { new Point(100, 50) };
            PointF[] vector = new PointF[] { new Point(100, 50) };

            // 绘制点point
            graphics.FillEllipse(brush, point[0].X - 5, point[0].Y - 5, 10, 10);
            //将点(10,10)与vector表示的位置连接起来
            graphics.DrawLine(pen, new Point(10, 10), vector[0]);

            // 定义变换矩阵
            Matrix matrix = new Matrix(0.8f, 0.6f, -0.6f, 0.8f, 100.0f, 0.0f);
            //对点point的位置信息进行变换
            matrix.TransformPoints(point);
            //对点vector的位置信息进行二维向量变换
            matrix.TransformVectors(vector);

            // 绘制变换后的点
            pen.Color = Color.Red;
            brush.Color = Color.Red;
            graphics.FillEllipse(brush, point[0].X - 5, point[0].Y - 5, 10, 10);
            //将点(10,10)与变换后的vector表示的位置连接起来
            graphics.DrawLine(pen, new Point(10, 10), vector[0]);
        }

        private void Matrix_RotateAt_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Blue, 4);
            Pen pen2 = new Pen(Color.Gray);

            //获取当前窗口区域
            RectangleF rect = new RectangleF(0, 0,
                this.ClientSize.Width, this.ClientSize.Height); ;
            //构造并平移矩阵到窗口中心点
            Matrix matrix = new Matrix();
            matrix.Translate(rect.Width / 2, rect.Height / 2);

            //将绘图平面依次旋转一周
            for (int i = 0; i < 360; i += 30)
            {
                //旋转矩阵，相对于窗口中心点
                matrix.RotateAt(i, new PointF(rect.Width / 2,
                    rect.Height / 2), MatrixOrder.Append);
                //将旋转后的矩阵作用于绘图平面
                graphics.Transform = matrix;
                //绘制椭圆
                graphics.DrawEllipse(pen, -80, -30, 160, 60);
                //重置作用在绘图平面是所有的变换
                graphics.ResetTransform();
            }

            //以窗口中心点为原点绘制坐标轴
            graphics.DrawLine(pen2, 0, rect.Height / 2,
                rect.Width, rect.Height / 2);
            graphics.DrawLine(pen2, rect.Width / 2, 0,
                rect.Width / 2, rect.Height);
        }

        private void Matrix_Shear_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //装入图片
            Bitmap image = new Bitmap("jieba.bmp");
            //定义图片的显示区域
            Rectangle rect = new Rectangle(0, 0, 100, 150);
            //绘制源图
            graphics.DrawImage(image, rect);

            Matrix matrix = new Matrix();
            //设置水平投射因子
            matrix.Shear(0.8f, 0.0f);
            //对绘图平面使用投射变换
            graphics.Transform = matrix;
            graphics.TranslateTransform(100, 0);
            //绘制投射变换后的图片
            graphics.DrawImage(image, rect);

            graphics.ResetTransform();
            Matrix matrix2 = new Matrix();
            //设置垂直投射因子
            matrix2.Shear(0.0f, 0.8f);
            //对绘图平面使用投射变换
            graphics.Transform = matrix2;
            graphics.TranslateTransform(200, 0);
            //绘制投射变换后的图片
            graphics.DrawImage(image, rect);
        }

        private void Matrix_TextoutShear_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush brush = new SolidBrush(Color.Blue);
            FontFamily fontFamily = new FontFamily("楷体_GB2312_GB2312");
            Font myFont = new Font(fontFamily, 20, FontStyle.Regular, GraphicsUnit.Pixel);

            Font myfont = new Font("Times New Roman", 100);
            Matrix mymat = new Matrix();
            //投射
            mymat.Shear(-1.4f, 0.0f);
            //缩放
            mymat.Scale(1, 0.5f);
            //平移
            mymat.Translate(236, 170);
            //对绘图平面实施坐标变换、、
            graphics.Transform = mymat;

            SolidBrush mybrush = new SolidBrush(Color.Gray);
            SolidBrush redbrush = new SolidBrush(Color.Red);
            //绘制阴影
            graphics.DrawString("Hello", myfont, mybrush, new PointF(0, 50));
            graphics.ResetTransform();
            //绘制前景
            graphics.DrawString("Hello", myfont, redbrush, new PointF(0, 50));
            string msg = string.Empty;
            //获取矩阵元素值
            float[] x = mymat.Elements;
            //输出每一个矩阵元素的值
            int i = 0;
            foreach (float elements in x)
            {
                msg += string.Format("{0,6:F2}", x[i]);
                //输出行向量
                if (i == 1 || i == 3 || i == 5)
                {
                    graphics.DrawString(msg, myFont, Brushes.Black,
                        new PointF(0, 0));
                    //垂直方向上下移一行
                    graphics.TranslateTransform(0, myFont.Height);
                    msg = string.Empty;
                }
                i++;
            }
        }

        private void Matrix_ChangeFontHeight_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //构造字体系列
            FontFamily fontFamily = new FontFamily("楷体_GB2312");
            //创建路径区域
            GraphicsPath path = new GraphicsPath();
            SolidBrush redBrush = new SolidBrush(Color.Red);

            //设置文本输出质量
            graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            //向区域中追加文本，字体大小为80
            path.AddString("大小渐变", fontFamily, (int)FontStyle.Regular,
                80, new Point(0, 0), new StringFormat());
            //获取路径所占的矩形区域
            RectangleF bound = path.GetBounds();
            //获取路径区域的中心点
            float halfH = bound.Height / 2;
            float halfW = bound.Width / 2;

            //对路径实施变换，更改路径区域的中心点
            Matrix pathMartrix = new Matrix(1, 0, 0, 1, -halfW, -halfH);
            path.Transform(pathMartrix);

            //获取路径的点信息
            PointF[] dataPoints = path.PathPoints;
            //获取路径的点类型信息
            byte[] pTypes = path.PathTypes;

            //依次对路径的定义点的Y值进行缩放
            for (int i = 0; i < path.PointCount; i++)
            {
                //根据该点距路径起点的距离占整个路径长度的比例更改Y值
                dataPoints[i].Y *= 2 * (bound.Width - Math.Abs(dataPoints[i].X)) / bound.Width;
            }

            //根据更改后的路径定义点重新构造路径
            GraphicsPath newpath = new GraphicsPath(dataPoints, pTypes);
            //将绘图平面的原点移到窗口中心
            graphics.TranslateTransform(this.ClientSize.Width / 2, this.ClientSize.Height / 2 - 40);
            //填充路径
            graphics.FillPath(redBrush, newpath);
        }

        private void ColorMatrix＿Start_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //加载图片
            Bitmap image = new Bitmap("ColorInput.bmp");
            int width = image.Width;
            int height = image.Height;
            ImageAttributes imageAttributes = new ImageAttributes();

            //定义色彩变换矩阵
            float[][] colorMatrixElements =
		{
			new float[]{2.0f, 0.0f, 0.0f, 0.0f, 0.0f},
			new float[] { 0.0f, 1.0f, 0.0f, 0.0f, 0.0f},
			new float[] { 0.0f, 0.0f, 1.0f, 0.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 1.0f, 0.0f},
			new float[]{1.0f, 0.0f, 0.0f, 0.0f, 1.0f}
		};
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);

            //启用色彩变换矩阵
            imageAttributes.SetColorMatrix(
                colorMatrix,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);

            //绘制源图
            graphics.DrawImage(image, 0, 0);
            //使用色彩变换矩阵输出图片
            graphics.TranslateTransform(width + 10, 0);
            graphics.DrawImage(
                image,
                new Rectangle(0, 0, width, height),
                0, 0,
                width, height, GraphicsUnit.Pixel,
                imageAttributes);
        }

        private void TranslateColor_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //加载图片
            Bitmap image = new Bitmap("ColorBar.bmp");
            ImageAttributes imageAttributes = new ImageAttributes();
            int width = image.Width;
            int height = image.Height;

            //定义色彩变换矩阵
            float[][] colorMatrixElements =
	{
		new float[]{1.0f,  0.0f, 0.0f, 0.0f, 0.0f},
		new float[]{0.0f,  1.0f, 0.0f, 0.0f, 0.0f},
		new float[]{0.0f,  0.0f, 1.0f, 0.0f, 0.0f},
		new float[]{0.0f,  0.0f, 0.0f, 1.0f, 0.0f},
		new float[]{0.75f, 0.0f, 0.0f, 0.0f, 1.0f}
	};
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);

            //启用色彩变换矩阵
            imageAttributes.SetColorMatrix(colorMatrix,
                ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            //绘制源图
            graphics.DrawImage(image, 0, 0);
            //使用色彩变换矩阵输出图片
            graphics.TranslateTransform(width + 10, 0);
            graphics.DrawImage(image, new Rectangle(0, 0, width, height),
                0, 0, width, height, GraphicsUnit.Pixel, imageAttributes);
        }

        private void ScaleColor_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //加载图片
            Bitmap image = new Bitmap("ColorBar.bmp");
            ImageAttributes imageAttributes = new ImageAttributes();
            int width = image.Width;
            int height = image.Height;

            //定义色彩变换矩阵1
            float[][] colorMatrixElements =
	{
		new float[]{0.5f, 0.0f, 0.0f, 0.0f, 0.0f},
		new float[]{0.0f, 0.5f, 0.0f, 0.0f, 0.0f},
		new float[]{0.0f, 0.0f, 0.50f, 0.0f, 0.0f},
		new float[]{0.0f, 0.0f, 0.0f, 1.0f, 0.0f},
		new float[]{0.0f, 0.0f, 0.0f, 0.0f, 1.0f}
	};
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            //定义色彩变换矩阵2
            float[][] colorMatrixElements2 =
	{
		new float[]{0.5f, 0.0f, 0.0f, 0.0f, 0.0f},
		new float[]{0.0f, 0.5f, 0.0f, 0.0f, 0.0f},
		new float[]{0.0f, 0.0f, 500.50f, 0.0f, 0.0f},
		new float[]{0.0f, 0.0f, 0.0f, 1.0f, 0.0f},
		new float[]{0.0f, 0.0f, 0.0f, 0.0f, 1.0f}
	};
            ColorMatrix colorMatrix2 = new ColorMatrix(colorMatrixElements2);

            //启用色彩变换矩阵1
            imageAttributes.SetColorMatrix(
                colorMatrix,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);

            //绘制源图
            graphics.DrawImage(image, 0, 0);
            //使用色彩变换矩阵输出图片
            graphics.TranslateTransform(width + 10, 0);
            graphics.DrawImage(
                image,
                new Rectangle(0, 0, width, height),
                0, 0,
                width, height, GraphicsUnit.Pixel,
                imageAttributes);

            //清除已经采取的色彩变换
            imageAttributes.ClearColorMatrix(ColorAdjustType.Bitmap);
            //重新加载另一变换矩阵Matrix2
            imageAttributes.SetColorMatrix(
                colorMatrix2,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);

            //演示使用Matrix2的色彩调整情况
            graphics.TranslateTransform(width + 10, 0);
            graphics.DrawImage(
                image,
                new Rectangle(0, 0, width, height),
                0, 0,
                width, height, GraphicsUnit.Pixel,
                imageAttributes);
        }

        private void RotateColor_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //加载图片
            Bitmap image = new Bitmap("Colorinput.bmp");
            int width = image.Width;
            int height = image.Height;
            float degrees = 90;
            //从角度到弧度
            double r = degrees * Math.PI / 180.0f;
            ImageAttributes imageAttributes = new ImageAttributes();
            //绘制源图
            graphics.DrawImage(image, 0, 0);

            //红色绕着蓝色旋转
            float[][] colorMatrixElements =
		{
			new float[]{(float)Math.Cos(r),  (float)Math.Sin(r), 0.0f, 0.0f, 0.0f},
			new float[]{-(float)Math.Sin(r), (float)Math.Cos(r), 0.0f, 0.0f, 0.0f},
			new float[]{0.0f,    0.0f,   1.0f, 0.0f, 0.0f},
			new float[]{0.0f,    0.0f,   0.0f, 1.0f, 0.0f},
			new float[]{0.0f,    0.0f,   0.0f, 0.0f, 1.0f}
		};
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);

            //使用色彩变换矩阵输出图片(R->B)
            graphics.TranslateTransform(width + 10, 0);
            //设置R->B色彩变换矩阵
            imageAttributes.SetColorMatrix(
                colorMatrix,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);
            graphics.DrawImage(
                image,
                new Rectangle(0, 10, width, height),
                0, 0, width, height,
                GraphicsUnit.Pixel,
                imageAttributes);

            //清除已经采取的色彩变换
            imageAttributes.ClearColorMatrix(ColorAdjustType.Bitmap);

            //重新加载另一变换矩阵Matrix2
            //绿色绕着红色旋转
            float[][] colorMatrixElements2 =
	{
		new float[]{1,  0, 0.0f, 0.0f, 0.0f},
		new float[]{0, (float)Math.Cos(r), (float)Math.Sin(r), 0.0f, 0.0f},
		new float[]{0.0f, -(float)Math.Sin(r), (float)Math.Cos(r), 0.0f, 0.0f},
		new float[]{0.0f,    0.0f,   0.0f, 1.0f, 0.0f},
		new float[]{0.0f,    0.0f,   0.0f, 0.0f, 1.0f}
	};
            ColorMatrix colorMatrix2 = new ColorMatrix(colorMatrixElements2);

            imageAttributes.SetColorMatrix(
                colorMatrix2,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);

            //在第二行输出
            graphics.ResetTransform();
            graphics.TranslateTransform(0, height + 10);
            graphics.DrawImage(image,
                new Rectangle(0, 0, width, height),
                0, 0, width, height, GraphicsUnit.Pixel,
                imageAttributes);

            //清除已经采取的色彩变换
            imageAttributes.ClearColorMatrix(ColorAdjustType.Bitmap);
            //蓝色绕着红色旋
            float[][] colorMatrixElements3 =
	{

		new float[]{(float)Math.Cos(r),  0, -(float)Math.Sin(r), 0.0f, 0.0f},
		new float[]{0, 1, 0.0f, 0.0f, 0.0f},
		new float[]{(float)Math.Sin(r), 0, (float)Math.Cos(r), 0.0f, 0.0f},
		new float[]{0.0f,    0.0f,   0.0f, 1.0f, 0.0f},
		new float[]{0.0f,    0.0f,   0.0f, 0.0f, 1.0f}
	};
            ColorMatrix colorMatrix3 = new ColorMatrix(colorMatrixElements3);

            //重新加载另一变换矩阵Matrix3
            imageAttributes.SetColorMatrix(
                colorMatrix3,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);
            graphics.TranslateTransform(width + 10, 0);
            graphics.DrawImage(
                image,
                new Rectangle(0, 0, width, height),
                0, 0,
                width, height, GraphicsUnit.Pixel,
                imageAttributes);
        }

        private void ColorShear_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //加载图片
            Bitmap image = new Bitmap("Colorinput.bmp");
            ImageAttributes imageAttributes = new ImageAttributes();
            int width = image.Width;
            int height = image.Height;

            //定义色彩变换矩阵
            float[][] colorMatrixElements =
	{
		new float[]{1.0f, 0.0f, 0.0f, 0.0f, 0.0f},
		new float[]{0.0f, 1.0f, 0.0f, 0.0f, 0.0f},
		new float[]{0.5f, 0.0f, 1.0f, 0.0f, 0.0f},
		new float[]{0.0f, 0.0f, 0.0f, 1.0f, 0.0f},
		new float[]{ 0.0f, 0.0f, 0.0f, 0.0f, 1.0f}
	};

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            //启用色彩变换矩阵
            imageAttributes.SetColorMatrix(
                colorMatrix,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);

            //绘制源图
            graphics.DrawImage(image, 0, 0);
            //使用色彩变换矩阵输出图片
            graphics.TranslateTransform(width + 10, 0);
            graphics.DrawImage(image, new Rectangle(0, 0, width, height),
                0, 0, width, height, GraphicsUnit.Pixel, imageAttributes);

        }

        private void ColorRemap_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //加载蓝色背景的图片
            Bitmap image = new Bitmap("Nemo_Blue.bmp");
            ImageAttributes imageAttributes = new ImageAttributes();

            int width = image.Width;
            int height = image.Height;
            //将蓝色替换成白色,以达到抠除的效果
            ColorMap colorMap = new ColorMap();
            colorMap.OldColor = Color.FromArgb(255, 0, 0, 255);
            colorMap.NewColor = Color.FromArgb(255, 255, 255, 255);
            //设置色彩转换表
            ColorMap[] remapTable = { colorMap };

            //设置图片的色彩信息
            imageAttributes.SetRemapTable(remapTable, ColorAdjustType.Bitmap);
            //绘制原始图像
            graphics.DrawImage(image, 0, 0, width, height);
            //绘制已经抠除背景色的新图像
            graphics.DrawImage(image,
                new Rectangle(width + 10, 0, width, height),  //目标区域
                0, 0,        // 源图左上角坐标
                width,       // 源图宽
                height,      // 源图宽
                GraphicsUnit.Pixel,
                //图片的色彩信息
                imageAttributes);
        }

        private void SetRGBOutputChannel_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //加载图片
            Bitmap image = new Bitmap("jieba.bmp");
            //绘制源图
            graphics.DrawImage(image, 0, 0);

            int width = image.Width;
            int height = image.Height;
            ImageAttributes imageAttributes = new ImageAttributes();

            //设置红色通道
            float[][] colorMatrixElements =
		{
			new float[]{1.0f, 0.0f, 0.0f, 0.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 0.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 0.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 1.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 0.0f, 1.0f}
		};
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);

            //启用色彩变换矩阵
            imageAttributes.SetColorMatrix(
                colorMatrix,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);
            //使用色彩变换矩阵输出图片
            graphics.TranslateTransform(width + 10, 0);
            graphics.DrawImage(image, new Rectangle(0, 0, width, height),
                0, 0, width, height, GraphicsUnit.Pixel, imageAttributes);

            //清除已经采取的色彩变换
            imageAttributes.ClearColorMatrix(ColorAdjustType.Bitmap);
            //设置绿色通道
            float[][] colorMatrixElements2 =
		{
			new float[]{0.0f, 0.0f, 0.0f, 0.0f, 0.0f},
			new float[]{0.0f, 1.0f, 0.0f, 0.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 0.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 1.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 0.0f, 1.0f}
		};
            ColorMatrix colorMatrix2 = new ColorMatrix(colorMatrixElements2);

            //启用色彩变换矩阵
            imageAttributes.SetColorMatrix(
                colorMatrix2,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);
            //使用色彩变换矩阵输出图片
            graphics.ResetTransform();
            graphics.TranslateTransform(0, height + 10);
            graphics.DrawImage(image, new Rectangle(0, 0, width, height),
                0, 0, width, height, GraphicsUnit.Pixel, imageAttributes);

            //清除已经采取的色彩变换
            imageAttributes.ClearColorMatrix(ColorAdjustType.Bitmap);

            //设置蓝色通道
            float[][] colorMatrixElements3 =
		{
			new float[]{0.0f, 0.0f, 0.0f, 0.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 0.0f, 0.0f},
			new float[]{0.0f, 0.0f, 1.0f, 0.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 1.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 0.0f, 1.0f}
		};
            ColorMatrix colorMatrix3 = new ColorMatrix(colorMatrixElements3);

            //启用色彩变换矩阵
            imageAttributes.SetColorMatrix(
                colorMatrix3,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);

            //使用色彩变换矩阵输出图片
            graphics.TranslateTransform(width + 10, 0);
            graphics.DrawImage(image, new Rectangle(0, 0, width, height),
                0, 0, width, height, GraphicsUnit.Pixel, imageAttributes);
        }

        private void Metafile_Click(object sender, System.EventArgs e)
        {
            Graphics metagraph = this.CreateGraphics();

            //新建一个图元文件
            IntPtr hdc = metagraph.GetHdc();
            Metafile metaFile1 = new Metafile("图元文件示例.emf", hdc);
            //使用Metafile对象的地址做为绘图平面
            Graphics graphics = Graphics.FromImage(metaFile1);

            //定义一个由红到蓝的渐变色画刷
            LinearGradientBrush RtoBBrush = new LinearGradientBrush(
                new Point(0, 10),
                new Point(200, 10),
                Color.Red,
                Color.Blue);

            //定义一个由蓝到黄的渐变色画刷
            LinearGradientBrush BtoYBrush = new LinearGradientBrush(
                new Point(0, 10),
                new Point(200, 10),
                Color.Blue,
                Color.Yellow);
            Pen bluePen = new Pen(Color.Blue);
            // 以下的操作是往屏幕上绘制一八卦图形
            Rectangle ellipseRect = new Rectangle(0, 0, 200, 200);
            Rectangle left = new Rectangle(0, 50, 100, 100);
            graphics.DrawArc(bluePen, left, 180.0f, 180.0f);
            Rectangle right = new Rectangle(100, 50, 100, 100);
            graphics.FillPie(RtoBBrush, ellipseRect, 0.0f, 180.0f);
            graphics.FillPie(BtoYBrush, ellipseRect, 180.0f, 180.0f);
            graphics.FillPie(RtoBBrush, left, 180.0f, 180.0f);
            graphics.FillPie(BtoYBrush, right, 0.0f, 180.0f);

            //文本输出 
            SolidBrush solidBrush = new SolidBrush(Color.Black);
            FontFamily fontFamily = new FontFamily("楷体_GB2312");
            Font font = new Font(fontFamily, 27,
                FontStyle.Regular, GraphicsUnit.Pixel);
            graphics.DrawString("图元文件示例", font, solidBrush,
                new PointF(20.0f, 80.0f));
            //到此，GDI+进行的只是往硬盘中存放图片信息的操作

            //释放所有资源。
            graphics.Dispose();
            metaFile1.Dispose();
            metagraph.ReleaseHdc(hdc);
            metagraph.Dispose();

            //将上面的绘图信息进行回放
            Graphics playbackGraphics = this.CreateGraphics();
            playbackGraphics.Clear(Color.White);
            //打开并显示图元文件
            Metafile metaFile2 = new Metafile("图元文件示例.emf");
            playbackGraphics.DrawImage(metaFile2, new Point(0, 0));
            //关闭已经打开的图元文件
            metaFile2.Dispose();
        }

        private void CroppingAndScaling_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //加载图片
            Bitmap image = new Bitmap("nemo.bmp");
            int width = image.Width;
            int height = image.Height;

            // 目标显示区域在源图大小的基础上放大1.4倍
            RectangleF destinationRect = new RectangleF(
                width + 10, 0.0f, 1.4f * width, 1.4f * height);
            //绘制源图
            graphics.DrawImage(image, 0, 0);

            //在目标区域内输出位图
            graphics.DrawImage(
                image,
                destinationRect,
                new RectangleF(0, 0,    // 原图左上角
                0.65f * width,      // 仅显示原图宽度的65%部分
                0.65f * height),      // 仅显示原图高度的65%部分
                GraphicsUnit.Pixel);
        }

        private void UsingInterpolationMode_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //装入图片
            Bitmap image = new Bitmap("eagle.bmp");
            int width = image.Width;
            int height = image.Height;

            //绘制源图
            graphics.DrawImage(
                image,
                new Rectangle(0, 0, width, height),  //目标区域 
                0, 0,        //源图左上角坐标
                width,       //源图宽度
                height,      //源图高
                GraphicsUnit.Pixel);

            //绘图平面右移
            graphics.TranslateTransform(width + 10, 0);
            //最临近插值法(低质量)
            graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            graphics.DrawImage(
                image,
                new RectangleF(0.0f, 0.0f, 0.6f * width, 0.6f * height),  //目标区域
                new RectangleF(0, 0,        //源图左上角坐标
                width,       //源图宽度
                height),      //源图高
                GraphicsUnit.Pixel);

            //绘图平面右移
            graphics.TranslateTransform(0.6f * width + 10, 0);
            // 高质量双线性插值法
            graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
            graphics.DrawImage(
                image,
                new RectangleF(0, 0, 0.6f * width, 0.6f * height),  //目标区域
                new Rectangle(0, 0,        //源图左上角坐标
                width,       //源图宽度
                height),      //源图高
                GraphicsUnit.Pixel);

            //绘图平面右移
            graphics.TranslateTransform(0.6f * width + 10, 0f);
            // 高质量双三次插值法
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.DrawImage(
                image,
                new RectangleF(0, 0, 0.6f * width, 0.6f * height),  //目标区域
                new Rectangle(0, 0,        //源图左上角坐标
                width,       //源图宽度
                height),      //源图高
                GraphicsUnit.Pixel);
        }

        private void RotateFlip_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);
            //加载图片	
            Bitmap photo = new Bitmap("nemo2.bmp");

            //得到图片尺寸
            int iWidth = photo.Width;
            int iHeight = photo.Height;
            //绘制原始图片
            graphics.DrawImage(photo, 10 + photo.Width + 2,
                10, photo.Width, photo.Height);
            //水平翻转图片 
            photo.RotateFlip(RotateFlipType.RotateNoneFlipX);
            //旋转后的图片
            graphics.DrawImage(photo, 10, 10, photo.Width, photo.Height);
        }

        private void ImageSkewing_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //定义图形的目标显示区域
            Point[] destination = new Point[]
		{
			new Point(200, 20),   //原始图像左上角映射后的坐标
			new Point(110, 100), //原始图像右上角映射后的坐标
			new Point(250, 30)  //原始图像左下角映射后的坐标
		};
            Bitmap image = new Bitmap("Stripes.bmp");
            // 绘制原始图像
            graphics.DrawImage(image, 0, 0);

            // 绘制基于平行四边形映射后的图像
            graphics.TranslateTransform(image.Width, 0);
            graphics.DrawImage(image, destination);

        }


        private void Cubeimage_Click(object sender, System.EventArgs e)
        {
            int WIDTH = 200;
            int LEFT = 200;
            int TOP = 200;

            Graphics graphics = this.CreateGraphics();
            //使用黑色做背景色清屏
            graphics.Clear(Color.Black);

            //设置插值模式：高质量双三次插值法
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //分别装入张贴在立方体三面的图片
            Bitmap face = new Bitmap("rose.bmp");
            Bitmap top = new Bitmap("flower.bmp");
            Bitmap right = new Bitmap("yujinxiang.bmp");

            //重新定义用于张贴在正面的图片坐标
            Point[] destinationFace = new Point[]
		{
			new Point(LEFT,TOP), 
			new Point(LEFT+WIDTH, TOP),
			new Point(LEFT, TOP+WIDTH)
		};
            //张贴正面图像
            graphics.DrawImage(face, destinationFace);

            //重新定义用于张贴在顶部的图片坐标	
            PointF[] destinationTop = new PointF[]
		{
			new PointF(LEFT+WIDTH/2, TOP-WIDTH/2),
			new PointF(LEFT+WIDTH/2+WIDTH, TOP-WIDTH/2), 
			new PointF(LEFT, TOP)
		};
            //张贴顶部面图像		
            graphics.DrawImage(top, destinationTop);

            //重新定义用于张贴在右侧的图片坐标				
            Point[] destinationRight = new Point[]
		{
			new Point(LEFT+WIDTH, TOP),
			new Point(LEFT+WIDTH/2+WIDTH, TOP-WIDTH/2), 
			new Point(LEFT+WIDTH,TOP+WIDTH)
		};
            //张贴右侧面图像						
            graphics.DrawImage(right, destinationRight);
        }

        public bool ThumbnailCallback()
        {
            return false;
        }

        private void ThumbnailImage_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //设置插值模式：高质量双三次插值法
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //加载欲查看缩略图的图片
            Bitmap image = new Bitmap("flower.bmp");
            //获取当前窗口大小
            Rectangle client = new Rectangle(0, 0,
                this.ClientSize.Width, this.ClientSize.Height);

            float width = image.Width;
            float height = image.Height;

            //获取指定大小的缩略图
            Image.GetThumbnailImageAbort myCallback =
                new Image.GetThumbnailImageAbort(ThumbnailCallback);
            Image pThumbnail = image.GetThumbnailImage(40, 40, myCallback, IntPtr.Zero);

            //将缩略图作为画刷
            TextureBrush picBrush = new TextureBrush(pThumbnail);
            //填充窗口
            graphics.FillEllipse(picBrush, client);
        }

        private void Clone_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Bitmap image = new Bitmap("head.bmp");
            int Height = image.Height;
            int Width = image.Width;

            //定义将图片切分成四个部分的区域
            RectangleF[] block = new RectangleF[4];
            block[0] = new Rectangle(0, 0, Width / 2, Height / 2);
            block[1] = new Rectangle(Width / 2, 0, Width / 2, Height / 2);
            block[2] = new Rectangle(0, Height / 2, Width / 2, Height / 2);
            block[3] = new Rectangle(Width / 2, Height / 2, Width / 2, Height / 2);

            //分别克隆图片的四个部分	
            Bitmap[] s = new Bitmap[4];
            s[0] = image.Clone(block[0], PixelFormat.DontCare);
            s[1] = image.Clone(block[1], PixelFormat.DontCare);
            s[2] = image.Clone(block[2], PixelFormat.DontCare);
            s[3] = image.Clone(block[3], PixelFormat.DontCare);
            //绘制图片的四个部分，各部分绘制时间间隔为1秒
            graphics.DrawImage(s[0], 0, 0);

            //延时，以达到分块显示的效果
            Thread.Sleep(1000);
            graphics.DrawImage(s[1], Width / 2, 0);
            Thread.Sleep(1000);
            graphics.DrawImage(s[3], Width / 2, Height / 2);
            Thread.Sleep(1000);
            graphics.DrawImage(s[2], 0, Height / 2);
        }

        private void Picturescale_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //装入图片
            Bitmap image = new Bitmap("photo.bmp");

            //定义图片的显示区域
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
            graphics.DrawImage(image, rect);

            //局部缩小的区域大小为80*80
            graphics.TranslateTransform(image.Width + 10, 0);
            Rectangle smallrect = new Rectangle(0, 0, 80, 80);
            //局部缩小
            graphics.DrawImage(image, smallrect, 80, 10, 106, 112, GraphicsUnit.Pixel);

            graphics.TranslateTransform(0, 100);
            //局部放大的区域大小为80*80
            Rectangle largerect = new Rectangle(0, 0, 80, 80);
            //绘制放大后的局部图像
            graphics.DrawImage(image, largerect, 56, 101, 35, 40, GraphicsUnit.Pixel);
        }

        private void ImageAttributesSetNoOp_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Bitmap image = new Bitmap("ColorTable.bmp");
            int width = image.Width;
            //绘制标准图片  
            graphics.DrawImage(image, 0, 0);

            graphics.TranslateTransform(image.Width + 10, 0);
            ImageAttributes imAtt = new ImageAttributes();

            //构造一个红色转换到绿色的变换矩阵   


            float[][] colorMatrixElements =
		{     
			new float[]{0.0f, 1.0f, 0.0f, 0.0f, 0.0f},
			new float[]{0.0f, 1.0f, 0.0f, 0.0f, 0.0f},
			new float[]{0.0f, 0.0f, 1.0f, 0.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 1.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 0.0f, 1.0f}
		};
            ColorMatrix brushMatrix = new ColorMatrix(colorMatrixElements);
            //设置色彩校正
            imAtt.SetColorMatrix(
                brushMatrix,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);

            //使用色彩校正绘制图片
            graphics.DrawImage(
                image,
                new Rectangle(0, 0, image.Width, image.Height),  //目标位置
                0, 0, image.Width, image.Height,        //源位置
                GraphicsUnit.Pixel,
                imAtt);

            //临时关闭色彩校正
            imAtt.SetNoOp(ColorAdjustType.Bitmap);

            //不使用色彩校正绘制图片红色->红色
            graphics.TranslateTransform(width + 10, 0);
            graphics.DrawImage(
                image,
                new Rectangle(0, 0, image.Width, image.Height),  //目标位置
                0, 0, image.Width, image.Height,          //源位置
                GraphicsUnit.Pixel,
                imAtt);

            //撤消对色彩校正的关闭
            imAtt.ClearNoOp(ColorAdjustType.Bitmap);

            //使用色彩校正绘制图片：红色->绿色
            graphics.TranslateTransform(width + 10, 0);
            graphics.DrawImage(
                image,
                new Rectangle(0, 0, image.Width, image.Height),  //目标位置
                0, 0, image.Width, image.Height,          //源位置
                GraphicsUnit.Pixel,
                imAtt);
        }


        private void CreateMetaFile()
        {
            Graphics metagraph = this.CreateGraphics();

            //新建一个图元文件
            IntPtr hdc = metagraph.GetHdc();
            Metafile metaFile1 = new Metafile("ddd.emf", hdc);
            //使用Metafile对象的地址做为绘图平面
            Graphics graphics = Graphics.FromImage(metaFile1);
            graphics.ScaleTransform(0.8f, 0.8f);

            //在沿水平方向输出三个椭圆并填充
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            //红色椭圆
            graphics.DrawEllipse(new Pen(Color.Red, 10),
                new Rectangle(0, 0, 75, 95));
            graphics.FillEllipse(Brushes.Red,
                new Rectangle(0, 0, 75, 95));

            //绿色椭圆
            graphics.DrawEllipse(new Pen(Color.Green, 10),
                new Rectangle(40, 0, 75, 95));
            graphics.FillEllipse(Brushes.Green,
                new Rectangle(40, 0, 75, 95));

            //蓝色椭圆
            graphics.DrawEllipse(new Pen(Color.Blue, 10),
                new Rectangle(80, 0, 75, 95));
            graphics.FillEllipse(Brushes.Blue, new Rectangle(80, 0, 75, 95));

            // 追加三种色彩的文本
            FontFamily fontFamily = new FontFamily("Arial");
            Font font = new Font(fontFamily,
                24, FontStyle.Regular, GraphicsUnit.Pixel);
            graphics.TextRenderingHint = TextRenderingHint.AntiAlias;

            //红色文字
            graphics.DrawString("GDI+", font, Brushes.Red,
                new PointF(-80.0f, 0.0f));
            //绿色文字
            graphics.DrawString("GDI+", font, Brushes.Green,
                new PointF(-80.0f, font.Height));
            //蓝色文字
            graphics.DrawString("GDI+", font, Brushes.Blue,
                new PointF(-80.0f, font.Height * 2));
            //释放所有资源。
            graphics.Dispose();
            metaFile1.Dispose();
            metagraph.ReleaseHdc(hdc);
            metagraph.Dispose();
        }

        private void SetColorMatrices_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //加载图元文件	
            Metafile image = new Metafile("ddd.emf");
            GraphicsUnit unit = GraphicsUnit.Pixel;
            //获取图片区间
            RectangleF rect = image.GetBounds(ref unit);

            //不使用任何色彩校正输出图片
            graphics.DrawImage(image, 0.0f, 0.0f, rect.Width, rect.Height);
            ImageAttributes imAtt = new ImageAttributes();

            //定义一个使红色分量递增1.5的矩阵
            float[][] colorMatrixElements =
		{ 
			new float[]{1.5f,  0.0f,  0.0f,  0.0f,  0.0f},
			new float[]{0.0f,  1.0f,  0.0f,  0.0f,  0.0f},
			new float[]{0.0f,  0.0f,  1.0f,  0.0f,  0.0f},
			new float[]{0.0f,  0.0f,  0.0f,  1.0f,  0.0f},
			new float[]{0.0f,  0.0f,  0.0f,  0.0f,  1.0f}
		};
            ColorMatrix defaultColorMatrix = new ColorMatrix(colorMatrixElements);

            //定义一个使绿色分量递增1.5的矩阵
            float[][] colorMatrixElements2 =
		{  
			new float[]{1.0f,  0.0f,  0.0f,  0.0f,  0.0f},
			new float[]{0.0f,  1.5f,  0.0f,  0.0f,  0.0f},
			new float[]{0.0f,  0.0f,  1.0f,  0.0f,  0.0f},
			new float[]{0.0f,  0.0f,  0.0f,  1.0f,  0.0f},
			new float[]{0.0f,  0.0f,  0.0f,  0.0f,  1.0f}
		};
            ColorMatrix defaultGrayMatrix = new ColorMatrix(colorMatrixElements2);

            //画笔的彩色色彩信息较校正矩阵：蓝色分量递增1.5的矩阵
            float[][] colorMatrixElements3 = 
		{  
			new float[]{1.0f,  0.0f,  0.0f,  0.0f,  0.0f},
			new float[]{0.0f,  1.0f,  0.0f,  0.0f,  0.0f},
			new float[]{0.0f,  0.0f,  1.5f,  0.0f,  0.0f},
			new float[]{0.0f,  0.0f,  0.0f,  1.0f,  0.0f},
			new float[]{0.0f,  0.0f,  0.0f,  0.0f,  1.0f}
		};
            ColorMatrix penColorMatrix = new ColorMatrix(colorMatrixElements3);

            //画笔的灰度色矩阵：所有分量递增1.5的矩阵
            float[][] colorMatrixElements4 =
	{      
		new float[]{1.5f,  0.0f,  0.0f,  0.0f,  0.0f},
		new float[]{0.0f,  1.5f,  0.0f,  0.0f,  0.0f},
		new float[]{0.0f,  0.0f,  1.5f,  0.0f,  0.0f},
		new float[]{0.0f,  0.0f,  0.0f,  1.0f,  0.0f},
		new float[]{0.0f,  0.0f,  0.0f,  0.0f,  1.0f}
	};

            ColorMatrix penGrayMatrix = new ColorMatrix(colorMatrixElements4);

            // 设置默认的彩色及灰度校正矩阵.
            //ColorAdjustType.Default:修改所有的色彩信息
            imAtt.SetColorMatrices(
                defaultColorMatrix,
                defaultGrayMatrix,
                ColorMatrixFlag.AltGrays,
                ColorAdjustType.Default);
            //使用校正矩阵绘制图元文件：校正所有的色彩
            graphics.TranslateTransform(image.Width + 10, 0);
            graphics.DrawImage(
                image,
                new Rectangle(0, 0, (int)rect.Width, (int)rect.Height),
                rect.X, rect.Y,
                rect.Width,
                rect.Height,
                GraphicsUnit.Pixel,
                imAtt);

            //设置画笔的彩色及灰度色彩校正矩阵
            //ColorAdjustType.Pen：修正画笔色彩
            imAtt.SetColorMatrices(
                penColorMatrix,
                penGrayMatrix,
                ColorMatrixFlag.AltGrays,
                ColorAdjustType.Pen);
            //在第二行绘制
            graphics.ResetTransform();
            graphics.TranslateTransform(0, image.Height);
            //使用修正后的画笔绘制图片 
            graphics.DrawImage(
                image,
                new Rectangle(0, 0, (int)rect.Width, (int)rect.Height),
                rect.X, rect.Y,
                rect.Width,
                rect.Height,
                GraphicsUnit.Pixel,
                imAtt);

            graphics.TranslateTransform(image.Width + 10, 0);
            //清除在画笔上的所有变换
            imAtt.ClearColorMatrix(ColorAdjustType.Pen);
            graphics.DrawImage(
                image,
                new Rectangle(0, 0, (int)rect.Width, (int)rect.Height),
                rect.X, rect.Y,
                rect.Width,
                rect.Height,
                GraphicsUnit.Pixel,
                imAtt);
        }

        private void SetOutputChannelColorProfile_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Bitmap image = new Bitmap("car.bmp");
            ImageAttributes imAtt = new ImageAttributes();
            int width = image.Width;
            int height = image.Height;
            Rectangle rect = new Rectangle(0, 0, width, height);
            //绘制原始图片
            graphics.DrawImage(image, rect);

            graphics.TranslateTransform(width, 0);
            //设置色彩配置文件
            imAtt.SetOutputChannelColorProfile(
                "kodak_dc.ICM", ColorAdjustType.Bitmap);

            //使用色彩配置文件输出图片
            graphics.DrawImage(
                image,
                rect,
                0, 0, width, height,
                GraphicsUnit.Pixel,
                imAtt);
        }

        private void Gammaadjust_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //装入原始图片
            Bitmap image = new Bitmap("warrior.bmp");
            int width = image.Width;
            int height = image.Height;

            // 设置字体信息
            Font myFont = new Font("宋体", 12);
            //设置提示信息的显示区域
            PointF origin = new PointF(width + 10, height + 20);
            SolidBrush blackBrush = new SolidBrush(Color.Black);

            ImageAttributes imAtt = new ImageAttributes();
            string msg = string.Empty;
            //从0-3依次调整输出图片时所使用的Gamma值
            for (float i = 0.0f; i < 3.0f; i += 0.1f)
            {
                //绘制原始图片
                graphics.DrawImage(image, 0, 0);

                //设置Gamma值
                imAtt.SetGamma(i, ColorAdjustType.Bitmap);
                //使用修改后Gamma值进行图片输出
                graphics.DrawImage(
                    image,
                    new Rectangle(width + 10, 0, width, height),  //目标区域
                    0, 0, width, height,           //源区域
                    GraphicsUnit.Pixel,
                    imAtt);
                msg = string.Format("正在修改Gamma值，Gamma={0:F2}", i);
                //显示当前的Gamma值信息
                graphics.DrawString(msg, myFont, blackBrush, origin);
                //延时一秒以便观看效果
                Thread.Sleep(100);
                graphics.Clear(Color.White);
                imAtt.ClearGamma();
            }

        }

        private void SetOutputChannel_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //装入图片
            Bitmap image = new Bitmap("jieba.bmp");
            //图片的高度
            int width = image.Width;
            int height = image.Height;

            //绘制原始图片
            graphics.DrawImage(image, new RectangleF(0, 0, width, height));
            ImageAttributes imAtt = new ImageAttributes();
            //设置色彩输出通道cyan
            imAtt.SetOutputChannel(ColorChannelFlag.ColorChannelC,
                ColorAdjustType.Bitmap);
            //右移，绘制图片
            graphics.TranslateTransform(width, 0);
            graphics.DrawImage(
                image,
                new Rectangle(0, 0, width, height),
                0, 0, width, height,
                GraphicsUnit.Pixel,
                imAtt);

            //设置色彩输出通道:magenta 
            imAtt.SetOutputChannel(ColorChannelFlag.ColorChannelM,
                ColorAdjustType.Bitmap);
            //右移，绘制图片
            graphics.TranslateTransform(width, 0);
            graphics.DrawImage(
                image,
                new Rectangle(0, 0, width, height),
                0, 0, width, height,
                GraphicsUnit.Pixel,
                imAtt);

            //设置色彩输出通道:yellow
            imAtt.SetOutputChannel(ColorChannelFlag.ColorChannelY,
                ColorAdjustType.Bitmap);
            //右移，绘制图片
            graphics.TranslateTransform(width, 0);
            graphics.DrawImage(
                image,
                new Rectangle(0, 0, width, height),
                0, 0, width, height,
                GraphicsUnit.Pixel,
                imAtt);

            //设置色彩输出通道:black
            imAtt.SetOutputChannel(ColorChannelFlag.ColorChannelK,
                ColorAdjustType.Bitmap);
            //右移，绘制图片
            graphics.TranslateTransform(width, 0);
            graphics.DrawImage(
                image,
                new Rectangle(0, 0, width, height),
                0, 0, width, height,
                GraphicsUnit.Pixel,
                imAtt);

        }

        private void Colorkey_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //装入前后背景图片
            Bitmap forground = new Bitmap("grid.bmp");
            Bitmap background = new Bitmap("snike.bmp");

            int width = background.Width;
            int height = background.Height;
            Rectangle rect = new Rectangle(0, 0, width, height);

            //将红色设置成关键色
            ImageAttributes imAtt = new ImageAttributes();
            imAtt.SetColorKey(
                Color.Red,
                Color.Red,
                ColorAdjustType.Bitmap);

            //绘制背景
            graphics.DrawImage(background, 0, 0);
            //绘制前景
            graphics.DrawImage(
                forground,
                rect,
                0, 0, forground.Width, forground.Height,
                GraphicsUnit.Pixel,
                imAtt);

            graphics.TranslateTransform(width + 20, 0);
            graphics.DrawImage(background, 0, 0);
            //清除已经应用的关键色信息
            imAtt.ClearColorKey(ColorAdjustType.Bitmap);
            ///将蓝色设置成关键色
            imAtt.SetColorKey(
                Color.Blue,
                Color.Blue,
                ColorAdjustType.Bitmap);
            graphics.DrawImage(forground,
                rect,
                0, 0, forground.Width, forground.Height,
                GraphicsUnit.Pixel,
                imAtt);
            graphics.TranslateTransform(width + 20, 0);

            //绘制源图
            graphics.DrawImage(background, 0, 0);
        }

        private void Setthreshold_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Bitmap image = new Bitmap("box-2.bmp");
            int Width = image.Width;
            int Height = image.Height;
            //绘制原始图片
            graphics.DrawImage(image, 10, 10, Width, Height);

            //将阈值从0到1依次运用
            ImageAttributes imAtt = new ImageAttributes();
            for (float i = 0.0f; i < 1.0f; i += 0.1f)
            {
                //设置输出图片时使用的阈值
                imAtt.SetThreshold(i, ColorAdjustType.Bitmap);
                //绘制已经使用了阈值的图片
                graphics.DrawImage(image,
                    new Rectangle(10 + Width, 10, Width, Height),
                    0, 0, Width, Height,
                    GraphicsUnit.Pixel,
                    imAtt);
                //延时
                Thread.Sleep(1000);
            }
        }

        private void AdjustedPalette_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);
            graphics.ScaleTransform(0.7f, 0.7f);

            //加载图片
            Bitmap image = new Bitmap("lord-256.bmp");
            //复制图片
            Bitmap image2 = (Bitmap)image.Clone();
            //获取图片使用的调色板信息
            ColorPalette palette = image.Palette;

            //获取调色板所包含的色彩总数
            int count = palette.Entries.Length;
            if (count < 1)
            {
                MessageBox.Show("图片无调色板信息可用");
                return;
            }

            //更改调色板中的每一种色彩信息		
            for (int i = 0; i < count; i++)
            {
                int r = palette.Entries[i].R / 2;
                int g = palette.Entries[i].G / 2;
                int b = palette.Entries[i].B / 2;

                if (r < 1)
                    r = 0;
                if (g < 1)
                    g = 0;
                if (b < 1)
                    b = 0;
                palette.Entries[i] = Color.FromArgb(255, r, g, b);
            }

            //设置图像的新调色板
            image.Palette = palette;
            //绘制原图
            graphics.DrawImage(image2, 0, 0);
            //绘制修改后的图片
            graphics.DrawImage(image, image.Width + 10, 0);
        }

        private void SetWrapMode_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //加载图片
            Bitmap image = new Bitmap("yueru.bmp");
            ImageAttributes imAtt = new ImageAttributes();

            //设置图片排列方式为WrapModeClamp：图片不进行平铺
            imAtt.SetWrapMode(WrapMode.Clamp, Color.Red);

            //缩小显示源图
            graphics.DrawImage(image,
                new Rectangle(0, 0, image.Width, image.Height),  //目标区域
                0, 0, 2 * image.Width, 2 * image.Height,      //源图片区域
                GraphicsUnit.Pixel,
                imAtt);

            graphics.TranslateTransform(image.Width + 10, 0);
            //设置图片排列方式为WrapModeTileFlipXY：图片在水平和垂直方向上同时翻转
            imAtt.SetWrapMode(WrapMode.TileFlipXY);
            graphics.DrawImage(image,
                new Rectangle(0, 0, image.Width, image.Height),  //目标区域
                0, 0, 2 * image.Width, 2 * image.Height,       //源图片区域
                GraphicsUnit.Pixel,
                imAtt);

            graphics.TranslateTransform(image.Width + 10, 0);
            //设置图片排列方式为WrapModeTileFlipX：图片在水平上翻转
            imAtt.SetWrapMode(WrapMode.TileFlipX);
            graphics.DrawImage(image,
                new Rectangle(0, 0, image.Width, image.Height),  //目标区域
                0, 0, 2 * image.Width, 2 * image.Height,       //源图片区域
                GraphicsUnit.Pixel,
                imAtt);

            graphics.TranslateTransform(image.Width + 10, 0);
            //设置图片排列方式为WrapModeTileFlipY：图片在垂直上翻转
            imAtt.SetWrapMode(WrapMode.TileFlipY);
            graphics.DrawImage(image,
                new Rectangle(0, 0, image.Width, image.Height),  //目标区域
                0, 0, 2 * image.Width, 2 * image.Height,       //源图片区域
                GraphicsUnit.Pixel,
                imAtt);
        }

        private void ListAllImageEncoders_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush brush = new SolidBrush(Color.Blue);
            FontFamily fontFamily = new FontFamily("楷体_GB2312_GB2312");
            Font myFont = new Font(fontFamily,
                20, FontStyle.Regular, GraphicsUnit.Pixel);

            ImageCodecInfo[] pImageCodecInfo;
            //获取编码器信息
            pImageCodecInfo = ImageCodecInfo.GetImageEncoders();

            //输出编码信息
            string msg = string.Empty;
            for (int j = 0; j < pImageCodecInfo.GetLength(0); ++j)
            {
                msg += string.Format("编码器名称:{0}\t文件格式扩展名:{1}\t\n",
                    pImageCodecInfo[j].CodecName, pImageCodecInfo[j].FilenameExtension);
            }
            graphics.DrawString(msg, myFont, brush,
                new PointF(0, 0));
        }

        private void ListImageEncoder_Detail_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            ImageCodecInfo[] pImageCodecInfo;
            //获取编码器信息
            pImageCodecInfo = ImageCodecInfo.GetImageEncoders();
            int sigCount;
            int j, k;
            j = 0;
            k = 0;
            string msg = string.Empty;
            //查询所有的编码器信息
            for (j = 0; j < pImageCodecInfo.GetLength(0); ++j)
            {
                msg += string.Format("开始描述第{0}种图形编码信息\n\n", j);
                msg += string.Format("编码标识: {0}\n",
                    pImageCodecInfo[j].Clsid);
                msg += string.Format("文件格式标识: {0}\n",
                    pImageCodecInfo[j].FormatID);
                msg += string.Format("编码器名称: {0}\n",
                    pImageCodecInfo[j].CodecName);
                msg += string.Format("编码器依存的动态连接库名: {0}\n",
                    pImageCodecInfo[j].DllName);
                msg += string.Format("编码描述: {0}\n",
                    pImageCodecInfo[j].FormatDescription);
                msg += string.Format("编码器对应的文件扩展名: {0}\n",
                    pImageCodecInfo[j].FilenameExtension);
                msg += string.Format("编码器的MIME类型描述: {0}\n",
                    pImageCodecInfo[j].MimeType);
                msg += string.Format("ImageCodecFlags枚举的标记集: {0}\n",
                    pImageCodecInfo[j].Flags.ToString());
                msg += string.Format("编码器版本: {0}\n",
                    pImageCodecInfo[j].Version);

                sigCount = pImageCodecInfo[j].SignaturePatterns.GetLength(0);
                msg += string.Format("与编码器对应的编码器签名的数组大小:{0}\n", sigCount);
                msg += string.Format("第{0}种图形编码信息描述完毕\n\n", j);

            }

            //将编码器的详细信息写入文件
            StreamWriter sw = new StreamWriter(@"listinfo.txt", false, System.Text.Encoding.Unicode);
            sw.Write(msg);
            sw.Close();
            MessageBox.Show("操作结束，请打开当前目录下的listinfo.txt查看编码器消息");
        }

        private void ListImageDecoder_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush brush = new SolidBrush(Color.Blue);
            FontFamily fontFamily = new FontFamily("楷体_GB2312_GB2312");
            Font myFont = new Font(fontFamily,
                20, FontStyle.Regular, GraphicsUnit.Pixel);

            ImageCodecInfo[] pImageCodecInfo;
            //获取编码器信息
            pImageCodecInfo = ImageCodecInfo.GetImageDecoders();

            //输出每一个解码器的详细信息
            string msg = string.Empty;
            for (int j = 0; j < pImageCodecInfo.GetLength(0); ++j)
            {
                msg += string.Format("解码器名称:{0}\t文件格式扩展名:{1}\t\n",
                    pImageCodecInfo[j].CodecName, pImageCodecInfo[j].FilenameExtension);

            }

            //显示信息
            graphics.DrawString(msg, myFont, brush,
                new PointF(0, 0));
        }
        private Guid GetEncoderClsid(string format)
        {
            Guid picGUID = new Guid();
            ImageCodecInfo[] pImageCodecInfo; ;
            //获取编码器信息
            pImageCodecInfo = ImageCodecInfo.GetImageEncoders();
            //查找指定格式文件的编码器信息
            for (int i = 0; i < pImageCodecInfo.GetLength(0); ++i)
            {	//MimeType：编码方式的具体描述
                if (format.CompareTo(pImageCodecInfo[i].MimeType.ToString()) == 0)
                {
                    picGUID = pImageCodecInfo[i].Clsid;
                }
            }
            return picGUID;
        }

        private void GetEncoderParameter_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush brush = new SolidBrush(Color.Blue);
            FontFamily fontFamily = new FontFamily("宋体");
            Font myFont = new Font(fontFamily, 16, FontStyle.Regular, GraphicsUnit.Pixel);

            string msg = string.Empty;
            // 为了查询将位图保存为JPEG格式的图片，新建一个位图
            Bitmap bitmap = new Bitmap(1, 1);

            //获取JPEG格式的图像编码器的标识
            Guid encoderClsid = new Guid();
            encoderClsid = GetEncoderClsid("image/png");

            // 获取转换成JPG所需要的具体参数信息
            EncoderParameters pEncoderParameters = new EncoderParameters();
            pEncoderParameters = bitmap.GetEncoderParameterList(encoderClsid);
            // 查看pEncoderParameters对象中多少个EncoderParameter类
            int count = pEncoderParameters.Param.GetLength(0);
            msg += string.Format("在编码参数数组中有{0}个EncoderParameter类\n每个类的详细信息为：\n", count);

            EncoderParameter[] pEncoderParameter = pEncoderParameters.Param;
            /*分别查看EncoderParameters对象中的
            每一个EncoderParameter对象的成员变量
            GUID、NumberOfValues、Type*/
            for (int i = 0; i < count; i++)
            {
                //将GUID值转换成字串 
                msg += string.Format("所需设置的第{0}个参数种类(GUID):{1}s\n", i, pEncoderParameter[i].Encoder.Guid);
                //查看在每一个参数种类下，可以设置的参数信息
                msg += string.Format("\t在该参数参数种类下，你可以进行的设置的参数分别如下\n");
                msg += string.Format("\t\t变量总数={0}\n", pEncoderParameter[i].NumberOfValues);
                msg += string.Format("\t\t参数类型={0}\n", pEncoderParameter[i].Type.ToString());
            }
            //输出编码参数列表信息
            graphics.DrawString(msg, myFont, brush,
                new PointF(0, 0));
            MessageBox.Show(msg);
            MessageBox.Show(Encoder.ChrominanceTable.Guid.ToString());
        }
        private string EncoderParameterCategoryFromGUID(Guid guid)
        {
            string ParameterCategory = string.Empty;
            if (guid == Encoder.Compression.Guid)
                ParameterCategory = "Compression";
            else if (guid == Encoder.ColorDepth.Guid)
                ParameterCategory = "ColorDepth";
            else if (guid == Encoder.ScanMethod.Guid)
                ParameterCategory = "ScanMethod";
            else if (guid == Encoder.Version.Guid)
                ParameterCategory = "Version";
            else if (guid == Encoder.RenderMethod.Guid)
                ParameterCategory = "RenderMethod";
            else if (guid == Encoder.Quality.Guid)
                ParameterCategory = "Quality";
            else if (guid == Encoder.Transformation.Guid)
                ParameterCategory = "Transformation";
            else if (guid == Encoder.LuminanceTable.Guid)
                ParameterCategory = "LuminanceTable";
            else if (guid == Encoder.ChrominanceTable.Guid)
                ParameterCategory = "ChrominanceTable";
            else if (guid == Encoder.SaveFlag.Guid)
                ParameterCategory = "SaveFlag";
            else
                ParameterCategory = "Unknown category";
            return ParameterCategory;
        }

        private string ShowAllEncoderParameters(string format)
        {
            string outmsg = string.Empty;

            //以位图为例，查看pImageCodecInfo的详细信息	
            Bitmap bitmap = new Bitmap("head.bmp");
            EncoderParameters encodersarameters = new EncoderParameters();

            // 获取编码所需的参数列表
            encodersarameters = bitmap.GetEncoderParameterList(GetEncoderClsid(format));
            //获取EncoderParameter对象总数
            int count = encodersarameters.Param.GetLength(0);
            outmsg += string.Format("在EncoderParameters中，有{0}个 EncoderParameter对象。\n",
                count);
            EncoderParameter[] pEncoderParameter;
            pEncoderParameter = encodersarameters.Param;

            // 查看每一个EncoderParameter对象信息
            for (int k = 0; k < count; ++k)
            {
                //还原GUID信息
                string strParameterCategory = EncoderParameterCategoryFromGUID(
                    pEncoderParameter[k].Encoder.Guid);
                outmsg += string.Format("\t参数种类: {0}.\n", strParameterCategory);
                outmsg += string.Format("\t该参数的属性值一共有 {0}个\n",
                    pEncoderParameter[k].NumberOfValues);
                outmsg += string.Format("\t数据类型{0}.\n", pEncoderParameter[k].Type);
            }
            //将所有信息导出outmsg
            return outmsg;
        }

        private void GetAllEncoderParameter_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //设置输出信息时使用的字体、画刷
            SolidBrush brush = new SolidBrush(Color.Blue);
            FontFamily fontFamily = new FontFamily("宋体");
            Font myFont = new Font(fontFamily, 16,
                FontStyle.Regular, GraphicsUnit.Pixel);

            //将参数列表详细信息保存到msg之中
            string msg = ShowAllEncoderParameters("image/jpeg");
            //显示参数列表信息
            graphics.DrawString(msg, myFont, Brushes.Black,
                new PointF(0, 0));
        }

        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }

        private void menuItem17_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Bitmap image = new Bitmap("snike.bmp");
            RectangleF rect = new RectangleF(0, 0, image.Width / 2, image.Height / 2);
            graphics.DrawImage(image, rect);

            ImageCodecInfo myImageCodecInfo;
            myImageCodecInfo = GetEncoderInfo("image/png");
            //将BMP保存为PNG文件,不使用编码参数
            image.Save("snike.png", myImageCodecInfo, new EncoderParameters(0));

            //使用第二种方法设置encoder参数
            image.Save("snike2.png", ImageFormat.Png);

            //分别打开两种方法保存的图像
            Bitmap image_png1 = new Bitmap("snike.png");
            Bitmap image_png2 = new Bitmap("snike2.png");

            //绘制PNG格式的图片
            graphics.TranslateTransform(rect.Width, 0);
            graphics.DrawImage(image_png1, rect);
            graphics.TranslateTransform(rect.Width, 0);
            graphics.DrawImage(image_png2, rect);

        }

        private void SaveBmp2tif_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Bitmap myBitmap;
            ImageCodecInfo myImageCodecInfo;
            Encoder myEncoder;
            EncoderParameter myEncoderParameter;
            EncoderParameters myEncoderParameters;

            myBitmap = new Bitmap("jieba.bmp");
            // 获取TIFF格式文件的编码信息
            myImageCodecInfo = GetEncoderInfo("image/tiff");

            // 创建一个描述压缩方式的参数对象
            myEncoder = Encoder.Compression;
            myEncoderParameters = new EncoderParameters(1);
            // 使用LZW压缩方式将图图存为 TIFF文件
            myEncoderParameter = new EncoderParameter(
                myEncoder,
                (long)EncoderValue.CompressionLZW);
            myEncoderParameters.Param[0] = myEncoderParameter;
            myBitmap.Save("jieba.tif", myImageCodecInfo, myEncoderParameters);
        }

        private void SaveBMP2JPG_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Bitmap myBitmap;
            ImageCodecInfo myImageCodecInfo;
            Encoder myEncoder;
            EncoderParameter myEncoderParameter;
            EncoderParameters myEncoderParameters;

            //打开BMP文件
            myBitmap = new Bitmap("car.bmp");
            //获取显示图片所需要区域
            Rectangle imgrect = new Rectangle(0, 0,
                myBitmap.Width, myBitmap.Height);

            graphics.DrawImage(myBitmap, imgrect);

            //获取JPEG格式的编码方式
            myImageCodecInfo = GetEncoderInfo("image/jpeg");

            //分别设置JPEG文件的图片质量
            //编码参数种类为Quality
            myEncoder = Encoder.Quality;
            //创建一个EncoderParameters对象，它仅包含一个 EncoderParameter对象
            myEncoderParameters = new EncoderParameters(1);

            //设置JPEG图片质量为25级
            myEncoderParameter = new EncoderParameter(myEncoder, 25L);
            myEncoderParameters.Param[0] = myEncoderParameter;
            myBitmap.Save("car025.jpg", myImageCodecInfo, myEncoderParameters);

            //设置JPEG图片质量为50级
            myEncoderParameter = new EncoderParameter(myEncoder, 50L);
            myEncoderParameters.Param[0] = myEncoderParameter;
            myBitmap.Save("car050.jpg", myImageCodecInfo, myEncoderParameters);

            //设置JPEG图片质量为75级
            myEncoderParameter = new EncoderParameter(myEncoder, 75L);
            myEncoderParameters.Param[0] = myEncoderParameter;
            myBitmap.Save("car075.jpg", myImageCodecInfo, myEncoderParameters);

            //分别显示不同图片质量的JPEG文件
            Bitmap image01 = new Bitmap("car025.jpg");
            //绘图平面右移
            graphics.TranslateTransform(imgrect.Width + 10, 0);
            graphics.DrawImage(image01, imgrect);

            Bitmap image02 = new Bitmap("car050.jpg");
            //重置绘图平面，下移
            graphics.ResetTransform();

            graphics.TranslateTransform(0, imgrect.Height + 10);
            graphics.DrawImage(image02, imgrect);

            Bitmap image05 = new Bitmap("car075.jpg");
            graphics.TranslateTransform(imgrect.Width + 10, 0);
            graphics.DrawImage(image02, imgrect);
        }

        private void TransformingJPEG_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Bitmap myBitmap;
            ImageCodecInfo myImageCodecInfo;
            Encoder myEncoder;
            EncoderParameter myEncoderParameter;
            EncoderParameters myEncoderParameters;

            //打开JPEG文件
            myBitmap = new Bitmap("car.jpg");
            //获取显示图片所需要区域
            Rectangle imgrect = new Rectangle(0, 0,
                myBitmap.Width, myBitmap.Height);
            //绘制原图
            graphics.DrawImage(myBitmap, imgrect);

            //获取JPEG格式的编码方式
            myImageCodecInfo = GetEncoderInfo("image/jpeg");

            //分别设置JPEG文件的位置变换信息
            //编码参数种类为Transformation
            myEncoder = Encoder.Transformation;
            //创建一上EncoderParameters对象，它仅包含一个 EncoderParameter对象
            myEncoderParameters = new EncoderParameters(1);

            // 将图片旋转90度后保存
            myEncoderParameter = new EncoderParameter(
                myEncoder, (long)EncoderValue.TransformRotate270);
            myEncoderParameters.Param[0] = myEncoderParameter;
            myBitmap.Save("car0_rotate.jpg", myImageCodecInfo, myEncoderParameters);

            //绘制旋转后的图片
            graphics.TranslateTransform(imgrect.Width, 0);
            myBitmap = new Bitmap("car0_rotate.jpg");
            //获取显示图片所需要区域
            imgrect = new Rectangle(0, 0,
                myBitmap.Width, myBitmap.Height);
            graphics.DrawImage(myBitmap, imgrect);
        }


        private void MultipleFrameImage_Click(object sender, System.EventArgs e)
        {
            Bitmap multi;
            Bitmap page2;
            Bitmap page3;
            Bitmap page4;

            ImageCodecInfo myImageCodecInfo;
            Encoder myEncoder;
            EncoderParameter myEncoderParameter;
            EncoderParameters myEncoderParameters;

            //装入四张不同格式的图片
            multi = new Bitmap("dog.bmp");
            page2 = new Bitmap("dog.gif");
            page3 = new Bitmap("cute.jpg");
            page4 = new Bitmap("cat.png");

            //获取tiff图像格式的编码信息
            myImageCodecInfo = GetEncoderInfo("image/tiff");

            //参数类型：SaveFlag
            myEncoder = Encoder.SaveFlag;
            //创建一个EncoderParameters对象，它仅包含一个 EncoderParameter对象
            myEncoderParameters = new EncoderParameters(1);

            //保存第一张图片
            myEncoderParameter = new EncoderParameter(
                myEncoder,
                (long)EncoderValue.MultiFrame);
            myEncoderParameters.Param[0] = myEncoderParameter;
            multi.Save("Multiframe.tiff", myImageCodecInfo, myEncoderParameters);

            //保存第二张图片
            myEncoderParameter = new EncoderParameter(
                myEncoder,
                (long)EncoderValue.FrameDimensionPage);
            myEncoderParameters.Param[0] = myEncoderParameter;
            multi.SaveAdd(page2, myEncoderParameters);

            //保存第三张图片
            myEncoderParameter = new EncoderParameter(
                myEncoder,
                (long)EncoderValue.FrameDimensionPage);
            myEncoderParameters.Param[0] = myEncoderParameter;
            multi.SaveAdd(page3, myEncoderParameters);

            //保存第四张图片
            myEncoderParameter = new EncoderParameter(
                myEncoder,
                (long)EncoderValue.FrameDimensionPage);
            myEncoderParameters.Param[0] = myEncoderParameter;
            multi.SaveAdd(page4, myEncoderParameters);

            // 关闭TIFF文件
            myEncoderParameter = new EncoderParameter(
                myEncoder,
                (long)EncoderValue.Flush);
            myEncoderParameters.Param[0] = myEncoderParameter;
            multi.SaveAdd(myEncoderParameters);
            MessageBox.Show("操作结束，请打开当前目录下的Multiframe.tiff查看图片添加结果");
        }
        private void GetImageFromMultyFrame_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //将窗口切分成四个部分，用以显示四幅帧图片
            Rectangle ClientRect = new Rectangle(0, 0,
                this.ClientSize.Width, this.ClientSize.Height);
            Rectangle r1 = new Rectangle(0, 0,
                ClientRect.Width / 2, ClientRect.Height / 2);
            Rectangle r2 = new Rectangle(ClientRect.Width / 2, 0,
                ClientRect.Width / 2, ClientRect.Height / 2);
            Rectangle r3 = new Rectangle(0,
                ClientRect.Height / 2, ClientRect.Width / 2, ClientRect.Height / 2);
            Rectangle r4 = new Rectangle(ClientRect.Width / 2,
                ClientRect.Height / 2, ClientRect.Width / 2, ClientRect.Height / 2);

            //打开TIF文件
            Bitmap multi = new Bitmap("Multiframe.tiff");

            //FrameDimension.Page:子帧图片
            FrameDimension pageGuid = FrameDimension.Page;

            //显示并保存第一帧图片
            multi.SelectActiveFrame(pageGuid, 0);
            graphics.DrawImage(multi, r1);
            multi.Save("Page0.png", ImageFormat.Png);

            //显示并保存第二帧图片
            multi.SelectActiveFrame(pageGuid, 1);
            graphics.DrawImage(multi, r2);
            multi.Save("Page1.png", ImageFormat.Png);

            ////显示并保存第三帧图片
            multi.SelectActiveFrame(pageGuid, 2);
            graphics.DrawImage(multi, r3);
            multi.Save("Page2.png", ImageFormat.Png);

            ////显示并保存第四帧图片
            multi.SelectActiveFrame(pageGuid, 3);
            graphics.DrawImage(multi, r4);
            multi.Save("Page3.png", ImageFormat.Png);
        }

        private void QueryImage_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            SolidBrush brush = new SolidBrush(Color.Black);
            FontFamily fontFamily = new FontFamily("宋体");
            Font myFont = new Font(fontFamily, 16, FontStyle.Regular, GraphicsUnit.Pixel);

            int count = 0;
            Bitmap image = new Bitmap("car.jpg");
            //获取图像的属性项
            PropertyItem[] propItem = image.PropertyItems;

            // 图像中共有多少属性名可供查询
            count = propItem.GetLength(0);
            if (count == 0)
            {
                MessageBox.Show("无属性名可供查询");
                return;
            }

            string tmp = string.Empty;
            for (int j = 0; j < count; ++j)
            {
                tmp += string.Format("第{0}个可供查找询的属性名的标记值为（16进制）：{1:X}\n",
                    j, propItem[j].Id);
                tmp += string.Format("第{0}个属性名对应的属性项的信息为：\n", j);

                //获取属性项详细描述信息
                tmp += string.Format("\t属性项的长度为{0}\n\t数据类型为{1}\n",
                    propItem[j].Len, propItem[j].Type.ToString());
            }

            //输出图像的属性信息
            graphics.DrawString(tmp, myFont, brush,
                new PointF(0, 0));
        }

        private void SetProp_Click(object sender, System.EventArgs e)
        {
            //装入图片以供修改
            Bitmap image = new Bitmap("car.jpg");

            // 设置图片的作者为Jasmine
            byte[] newWriterValue = {(byte)'J', (byte)'a',
								(byte)'s', (byte)'m', (byte)'i', (byte)'e'};

            PropertyItem[] pp = image.PropertyItems;

            //0x13b：该标记值对应图片作者
            pp[0].Id = 0x13b;
            //属性值长度
            pp[0].Len = newWriterValue.GetLength(0);
            //2：属性值的数据类型为字符串
            pp[0].Type = 2;
            pp[0].Value = newWriterValue;

            //设置图片属性
            image.SetPropertyItem(pp[0]);
            image.Save("newwriter.jpg");

            //重新加载修改后的图片
            Bitmap image2 = new Bitmap("newwriter.jpg");
            //查看图片的作者信息
            pp[1] = image2.GetPropertyItem(0x13b);
            string msg = string.Empty;
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            string manufacturer = encoding.GetString(pp[1].Value);
            msg = string.Format("图片的作者已经更改为\n{0}", manufacturer);
            MessageBox.Show(msg);
        }

        private void OnCanvas_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);
            graphics.ScaleTransform(0.7f, 0.7f);

            Bitmap image = new Bitmap("box-2.bmp");

            int Width = image.Width;
            int Height = image.Height;
            Color color;
            graphics.DrawImage(image,
                new Rectangle(0, 0, Width, Height));

            //产生随机数序列
            Random rand = new Random();
            for (int i = 0; i < Width - 5; i++)
            {
                for (int j = 0; j < Height - 5; j++)
                {
                    int a = rand.Next(1000) % 5;

                    color = image.GetPixel(i + a, j + a);
                    //将该点的RGB值设置成附近五点之内的任一点
                    image.SetPixel(i, j, color);
                }
                //动态绘制滤镜效果图
                graphics.DrawImage(image,
                    new Rectangle(Width, 0, Width, Height));
            }

        }

        private void OnWood_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);
            graphics.ScaleTransform(0.7f, 0.7f);

            Bitmap image = new Bitmap("box-2.bmp");

            int Width = image.Width;
            int Height = image.Height;
            Color colorTemp, color2;
            Color color;
            //绘制原图
            graphics.DrawImage(
                image, new Rectangle(0, 0, Width, Height));
            int tmp;
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    color = image.GetPixel(i, j);
                    //根据该点RGB的平均值来确认该点的”明暗”
                    int avg;
                    avg = (color.R + color.G + color.B) / 3;
                    if (avg >= 128)
                        tmp = 255;
                    else
                        tmp = 0;
                    colorTemp = Color.FromArgb(255, tmp, tmp, tmp);
                    //将计算后的RGB值回写到位图
                    image.SetPixel(i, j, colorTemp);
                }
                //动态绘制滤镜效果图
                graphics.DrawImage(
                    image, new Rectangle(Width, 0, Width, Height));
            }

        }
        //计算两点A、B之间的绝对距离
        float fDistance(Point A, Point B)
        {
            double i = Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2);
            return (float)Math.Sqrt(i);
        }

        private void Flashligt_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            Bitmap image = new Bitmap("sports.bmp");
            int Width = image.Width;
            int Height = image.Height;
            int A = Width / 2;
            int B = Height / 2;
            //Center:图片中心点，发亮此值会让强光中心发生偏移
            Point Center = new Point(A, B);
            //R：强光照射面的半径，即”光晕”
            int R = 100;
            Color colorTemp, color2;
            Color color;
            graphics.DrawImage(
                image, new Rectangle(0, 0, Width, Height));
            //依次访问每个像素
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Point tmp = new Point(x, y);
                    //如果像素位于”光晕”之内
                    if (fDistance(tmp, Center) < R)
                    {
                        color = image.GetPixel(x, y);
                        int r, g, b;
                        //根据该点距离强光中心点的距离，分别让RGB值变量
                        //220:亮度增加常量，该值越大，光亮度越强
                        float tmp_r = 220.0f * (1.0f - fDistance(tmp, Center) / R);

                        r = color.R + (int)tmp_r;
                        r = Math.Max(0, Math.Min(r, 255));

                        g = color.G + (int)tmp_r;
                        g = Math.Max(0, Math.Min(g, 255));
                        b = color.B + (int)tmp_r;
                        b = Math.Max(0, Math.Min(b, 255));

                        colorTemp = Color.FromArgb(255, (int)r, (int)g, (int)b);
                        //将增亮后的像素值回写到位图
                        image.SetPixel(x, y, colorTemp);
                    }
                }
                //动态绘制滤镜效果图
                graphics.DrawImage(
                    image, new Rectangle(Width, 0, Width, Height));
            }
            /*如果在此处使用graphics.DrawImage(
            image, new Rectangle(Width, 0, Width, Height));
            绘制过程是静态的*/



        }

        private void BlurAndSharpen_Click(object sender, System.EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);
            graphics.ScaleTransform(0.8f, 0.8f);

            Bitmap image = new Bitmap("snike.bmp");

            int Width = image.Width;
            int Height = image.Height;
            //image2:进行锐化处理
            Bitmap image2 = (Bitmap)image.Clone();

            Color colorTemp;
            Color[,] color = new Color[3, 3];
            //绘制原图
            graphics.DrawImage(
                image, new Rectangle(0, 0, Width, Height));

            for (int i = 1; i < Width - 2; i++)
            {
                for (int j = 1; j < Height - 2; j++)
                {
                    //访问周围9个点的RGB值
                    color[0, 0] = image.GetPixel(i - 1, j - 1);
                    color[0, 1] = image.GetPixel(i - 1, j);
                    color[0, 2] = image.GetPixel(i - 1, j + 1);

                    color[1, 0] = image.GetPixel(i, j - 1);
                    color[1, 1] = image.GetPixel(i, j);
                    color[1, 2] = image.GetPixel(i, j + 1);

                    color[2, 0] = image.GetPixel(i + 1, j - 1);
                    color[2, 1] = image.GetPixel(i + 1, j);
                    color[2, 2] = image.GetPixel(i + 1, j + 1);

                    int rSum = 0;
                    int gSum = 0;
                    int bSum = 0;
                    //分别求出周围9个点的R、G、B之和
                    for (int n = 0; n < 3; n++)
                        for (int nn = 0; nn < 3; nn++)
                        {
                            rSum += color[n, nn].R;
                            gSum += color[n, nn].G;
                            bSum += color[n, nn].B;
                        }
                    //用RGB的平均值做为当前点的RGB值
                    colorTemp = Color.FromArgb(255,
                        (int)(rSum / 9), (int)(gSum / 9), (int)(bSum / 9));
                    //将计算后的RGB值回写到位图
                    image.SetPixel(i, j, colorTemp);
                }
                //绘制经过平滑处理的效果图
                graphics.DrawImage(
                    image, new Rectangle(Width, 0, Width, Height));
            }

            //进行锐化处理
            Color colorLeft, colornow;
            //常量dep：锐化系数，此值越大，锐化效果越明显
            float dep = 0.550f;
            for (int i = 1; i < Width - 1; i++)
            {
                for (int j = 1; j < Height - 1; j++)
                {
                    colornow = image2.GetPixel(i, j);
                    colorLeft = image2.GetPixel(i - 1, j - 1);

                    float r = colornow.R + (colornow.R
                        - colorLeft.R * dep);
                    r = Math.Min(255, Math.Max(0, r));

                    float g = colornow.G + (colornow.G
                        - colorLeft.G * dep);
                    g = Math.Min(255, Math.Max(0, g));
                    float b = colornow.B + (colornow.B
                        - colorLeft.B * dep);
                    b = Math.Min(255, Math.Max(0, b));

                    colorTemp = Color.FromArgb(255, (int)r, (int)g, (int)b);

                    //将计算后的RGB值回写到位图
                    image2.SetPixel(i, j, colorTemp);
                }

                graphics.DrawImage(
                    image2, new Rectangle(Width * 2, 0, Width, Height));

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}	
