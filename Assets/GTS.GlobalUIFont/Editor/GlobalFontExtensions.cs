﻿/*
================================================================================
    Product:    Unity-Set-Global_UI-Text_Font
    Developer:  GlassToeStudio@gmail.com
    Source:     https://github.com/GlassToeStudio/Unity-Set-Global-UI-Text-Font
    Company:    GlassToeStudio
    Website:    http://glasstoestudio.weebly.com/
    Date:       June 19, 2018
=================================================================================
    MIT License
================================================================================
*/

using System;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Small System to change the global font from "Arial" to another font of your choosing.
/// </summary>
namespace GTS.GlobalUIFont.Tools
{
    /// <summary>
    /// Various helper methods for the Text class.
    /// </summary>
    public static class GlobalFontExtensions
    {
        // Character

        #region SetFont()

        /// <summary>
        /// Set the Font of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"> this Text object</param>
        /// <param name="font">The font that this Text object will be set.</param>
        public static void SetFont(this Text t, Font font)
        {
            t.font = font;
        }
        /// <summary>
        /// Set the Font of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"> this Text object</param>
        /// <param name="text">The Text object with font that this Text object will be set.</param>
        public static void SetFont(this Text t, Text text)
        {
            t.SetFont(text.font);
        }
        /// <summary>
        /// Set the Font of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"> this Text object</param>
        /// <param name="fontData">The FontData with the font that this Text object will be set.</param>
        public static void SetFont(this Text t, FontData fontData)
        {
            t.SetFont(fontData.font);
        }
        /// <summary>
        /// Set the Font of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"> this Text object</param>
        /// <param name="toValue">The generic T with the font that this Text object will be set.</param>
        public static void SetFont<T>(this Text t, T toValue)
        {
            t.SetFont(toValue as Font);
        }

        #endregion

        #region SetFontStyle()

        /// <summary>
        /// Set the FontStyle of this Text object with the passed in value.
        /// </summary>
        /// <param name="t">this Text object</param>
        /// <param name="fontStyle">The FontStyle that this Text object will be set.</param>
        public static void SetFontStyle(this Text t, FontStyle fontStyle)
        {
            t.fontStyle = fontStyle;
        }
        /// <summary>
        /// Set the FontStyle of this Text object with the passed in value.
        /// </summary>
        /// <param name="t">this Text object</param>
        /// <param name="text">The Text with the FontStyle that this Text object will be set.</param>
        public static void SetFontStyle(this Text t, Text text)
        {
            t.SetFontStyle(text.fontStyle);
        }
        /// <summary>
        /// Set the FontStyle of this Text object with the passed in value.
        /// </summary>
        /// <param name="t">this Text object</param>
        /// <param name="fontData">The FontData with FontStyle that this Text object will be set.</param>
        public static void SetFontStyle(this Text t, FontData fontData)
        {
            t.SetFontStyle(fontData.fontStyle);
        }
        /// <summary>
        /// Set the FontStyle of this Text object with the passed in value.
        /// </summary>
        /// <param name="t">this Text object</param>
        /// <param name="fontData">The FontData with FontStyle that this Text object will be set.</param>
        public static void SetFontStyle<T>(this Text t, T toValue)
        {
            t.SetFontStyle((FontStyle)Enum.Parse(typeof(T), toValue.ToString()));
        }
        
        #endregion

        #region SetFontSize()

        /// <summary>
        /// Set the FontSize of this Text object with the passed in value.
        /// </summary>
        /// <param name="t">this Text object</param>
        /// <param name="fontSize">The FontSize that this Text object will be set.</param>
        public static void SetFontSize(this Text t, int fontSize)
        {
            t.fontSize = fontSize;
        }
        /// <summary>
        /// Set the FontSize of this Text object with the passed in value.
        /// </summary>
        /// <param name="t">this Text object</param>
        /// <param name="text">The Text with the FontSize that this Text object will be set.</param>
        public static void SetFontSize(this Text t, Text text)
        {
            t.SetFontSize(text.fontSize);
        }
        /// <summary>
        /// Set the FontSize of this Text object with the passed in value.
        /// </summary>
        /// <param name="t">this Text object</param>
        /// <param name="fontData">The FontData with the FontSize that this Text object will be set.</param>
        public static void SetFontSize(this Text t, FontData fontData)
        {
            t.SetFontSize(fontData.fontSize);
        }
        /// <summary>
        /// Set the FontSize of this Text object with the passed in value.
        /// </summary>
        /// <param name="t">this Text object</param>
        /// <param name="fontData">The FontData with the T that this Text object will be set.</param>
        public static void SetFontSize<T>(this Text t, T toValue)
        {
            t.SetFontSize(Convert.ToInt32(toValue));
        }

        #endregion

        #region SetLineSpacing()

        /// <summary>
        /// Set the Line Spacing of this Text object with the passed in value.
        /// </summary>
        /// <param name="t">this Text object</param>
        /// <param name="lineSpacing">The Line Spacing that this Text object will be set.</param>
        public static void SetLineSpacing(this Text t, float lineSpacing)
        {
            t.lineSpacing = lineSpacing;
        }
        /// <summary>
        /// Set the Line Spacing of this Text object with the passed in value.
        /// </summary>
        /// <param name="t">this Text object</param>
        /// <param name="text">The Text with the Line Spacing that this Text object will be set.</param>
        public static void SetLineSpacing(this Text t, Text text)
        {
            t.SetLineSpacing(text.lineSpacing);
        }
        /// <summary>
        /// Set the Line Spacing of this Text object with the passed in value.
        /// </summary>
        /// <param name="t">this Text object</param>
        /// <param name="fontData">The FontData with the Line Spacing that this Text object will be set.</param>
        public static void SetLineSpacing(this Text t, FontData fontData)
        {
            t.SetLineSpacing(fontData.lineSpacing);
        }
        /// <summary>
        /// Set the Line Spacing of this Text object with the passed in value.
        /// </summary>
        /// <param name="t">this Text object</param>
        /// <param name="fontData">The FontData with the Line Spacing that this Text object will be set.</param>
        public static void SetLineSpacing<T>(this Text t, T toValue)
        {
            t.SetLineSpacing(Convert.ToSingle(toValue));
        }

        #endregion

        #region SetRichText()

        /// <summary>
        /// Set supportRichText of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="supportRichText"></param>
        public static void SetRichText(this Text t, bool supportRichText)
        {
            t.supportRichText = supportRichText;
        }
        /// <summary>
        /// Set supportRichText of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="text"></param>
        public static void SetRichText(this Text t, Text text)
        {
            t.SetRichText(text.supportRichText);
        }
        /// <summary>
        /// Set supportRichText of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="fontData"></param>
        public static void SetRichText(this Text t, FontData fontData)
        {
            t.SetRichText(fontData.supportRichText);
        }
        /// <summary>
        /// Set supportRichText of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="fontData"></param>
        public static void SetRichText<T>(this Text t, T toValue)
        {
            t.SetRichText(Convert.ToBoolean(toValue));
        }

        #endregion

        // Paragraph

        #region SetAlignment()

        /// <summary>
        /// Set alignment of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="textAnchor"></param>
        public static void SetAlignment(this Text t, TextAnchor textAnchor)
        {
            t.alignment = textAnchor;
        }
        /// <summary>
        /// Set alignment of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="text"></param>
        public static void SetAlignment(this Text t, Text text)
        {
            t.SetAlignment(text.alignment);
        }
        /// <summary>
        /// Set alignment of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="fontData"></param>
        public static void SetAlignment(this Text t, FontData fontData)
        {
            t.SetAlignment(fontData.alignment);
        }
        /// <summary>
        /// Set alignment of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="toValue"></param>
        /// <typeparam name="T"></typeparam>
        public static void SetAlignment<T>(this Text t, T toValue)
        {
            t.SetAlignment((TextAnchor)Enum.Parse(typeof(T), toValue.ToString()));
        }

        #endregion

        #region SetAlignByGeometry()
        
        /// <summary>
        /// Set the alignment by geometry property of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="alignByGeometry"></param>
        public static void SetAlignByGeometry(this Text t, bool alignByGeometry)
        {
            t.alignByGeometry = alignByGeometry;
        }
        /// <summary>
        /// Set the alignment by geometry property of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="text"></param>
        public static void SetAlignByGeometry(this Text t, Text text)
        {
            t.SetAlignByGeometry(text.alignByGeometry);
        }
        /// <summary>
        /// Set the alignment by geometry property of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="fontData"></param>
        public static void SetAlignByGeometry(this Text t, FontData fontData)
        {
            t.SetAlignByGeometry(fontData.alignByGeometry);
        }
        /// <summary>
        /// Set the alignment by geometry property of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="toValue"></param>
        /// <typeparam name="T"></typeparam>
        public static void SetAlignByGeometry<T>(this Text t, T toValue)
        {
            t.SetAlignByGeometry(Convert.ToBoolean(toValue));
        }

        #endregion

        #region SetHorizontalOverflow()

        /// <summary>
        /// Set the horizontal overflow mode of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="horizontalOverflow"></param>
        public static void SetHorizontalOverflow(this Text t, HorizontalWrapMode horizontalOverflow)
        {
            t.horizontalOverflow = horizontalOverflow;
        }
        /// <summary>
        /// Set the horizontal overflow mode of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="text"></param>
        public static void SetHorizontalOverflow(this Text t, Text text)
        {
            t.SetHorizontalOverflow(text.horizontalOverflow);
        }
        /// <summary>
        /// Set the horizontal overflow mode of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="fontData"></param>
        public static void SetHorizontalOverflow(this Text t, FontData fontData)
        {
            t.SetHorizontalOverflow(fontData.horizontalOverflow);
        }
        /// <summary>
        /// Set the horizontal overflow mode of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="toValue"></param>
        /// <typeparam name="T"></typeparam>
        public static void SetHorizontalOverflow<T>(this Text t, T toValue)
        {
            t.SetHorizontalOverflow((HorizontalWrapMode)Enum.Parse(typeof(T), toValue.ToString()));
        }

        #endregion

        #region SetVerticalOverflow()

        /// <summary>
        /// Set the vertical overflow mode of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="verticalOverflow"></param>
        public static void SetVerticalOverflow(this Text t, VerticalWrapMode verticalOverflow)
        {
            t.verticalOverflow = verticalOverflow;
        }
        /// <summary>
        /// Set the vertical overflow mode of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="text"></param>
        public static void SetVerticalOverflow(this Text t, Text text)
        {
            t.SetVerticalOverflow(text.verticalOverflow);
        }
        /// <summary>
        /// Set the vertical overflow mode of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="fontData"></param>
        public static void SetVerticalOverflow(this Text t, FontData fontData)
        {
            t.SetVerticalOverflow(fontData.verticalOverflow);
        }
        /// <summary>
        /// Set the vertical overflow mode of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="toValue"></param>
        /// <typeparam name="T"></typeparam>
        public static void SetVerticalOverflow<T>(this Text t, T toValue)
        {
            t.SetVerticalOverflow((VerticalWrapMode)Enum.Parse(typeof(T), toValue.ToString()));
        }

        #endregion

        #region SetBestFit()

        /// <summary>
        /// Set the resize for best fit property of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="resizeTextForBestFit"></param>
        public static void SetBestFit(this Text t, bool resizeTextForBestFit)
        {
            t.resizeTextForBestFit = resizeTextForBestFit;
        }
        /// <summary>
        /// Set the resize for best fit property of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="text"></param>
        public static void SetBestFit(this Text t, Text text)
        {
            t.SetBestFit(text.resizeTextForBestFit);
        }
        /// <summary>
        /// Set the resize for best fit property of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="fontData"></param>
        public static void SetBestFit(this Text t, FontData fontData)
        {
            t.SetBestFit(fontData.resizeTextForBestFit);
        }
        /// <summary>
        /// Set the resize for best fit property of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="toValue"></param>
        /// <typeparam name="T"></typeparam>
        public static void SetBestFit<T>(this Text t, T toValue)
        {
            t.SetBestFit(Convert.ToBoolean(toValue));
        }

        #endregion
 
        #region SetFontColor()

        /// <summary>
        /// Set the Color of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="color"></param>
        public static void SetFontColor(this Text t, Color color)
        {
            t.color = color;
        }
        /// <summary>
        /// Set the Color of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="text"></param>
        public static void SetFontColor(this Text t, Text text)
        {
            t.SetFontColor(text.color);
        }
        /// <summary>
        /// Set the Color of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="fontData"></param>
        public static void SetFontColor(this Text t, FontData fontData)
        {
            t.SetFontColor(fontData.color);
        }
        /// <summary>
        /// Set the Color of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="fontData"></param>
        public static void SetFontColor<T>(this Text t, T toValue)
        {
            t.SetFontColor((Color)Convert.ChangeType(toValue, typeof(Color)));
        }

        #endregion

        #region SetMaterial()

        /// <summary>
        /// Set the material of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="material"></param>
        public static void SetMaterial(this Text t, Material material)
        {
            t.material = material;
        }
        /// <summary>
        /// Set the material of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="text"></param>
        public static void SetMaterial(this Text t, Text text)
        {
            t.SetMaterial(text.material);
        }
        /// <summary>
        /// Set the material of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="fontData"></param>
        public static void SetMaterial(this Text t, FontData fontData)
        {
            t.SetMaterial(fontData.material);
        }
        /// <summary>
        /// Set the material of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="toValue"></param>
        /// <typeparam name="T"></typeparam>
        public static void SetMaterial<T>(this Text t, T toValue)
        {
            t.SetMaterial((Material)Convert.ChangeType(toValue, typeof(Material)));
        }

        #endregion
        
        #region SetRaycastTarget()

        /// <summary>
        /// Set the raycast target property of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="raycastTarget"></param>
        public static void SetRaycastTarget(this Text t, bool raycastTarget)
        {
            t.raycastTarget = raycastTarget;
        }
        /// <summary>
        /// Set the raycast target property of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="text"></param>
        public static void SetRaycastTarget(this Text t, Text text)
        {
            t.SetRaycastTarget(text.raycastTarget);
        }
        /// <summary>
        /// Set the raycast target property of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="fontData"></param>
        public static void SetRaycastTarget(this Text t, FontData fontData)
        {
            t.SetRaycastTarget(fontData.raycastTarget);
        }
        /// <summary>
        /// Set the raycast target property of this Text object with the passed in value.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="toValue"></param>
        /// <typeparam name="T"></typeparam>
        public static void SetRaycastTarget<T>(this Text t, T toValue)
        {
            t.SetRaycastTarget(Convert.ToBoolean(toValue));
        }

        #endregion
    }
}
