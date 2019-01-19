using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Collections;
using System.Drawing;


namespace WebACAddin
{
    class PreservUtil
    {
        private WebBrowser b;
        private HtmlDocument d;

        //コンストラクタ
        public PreservUtil(ref WebBrowser b)
        {
            this.b = b;
            this.d = b.Document;
        }

        //段落を枠で囲う
        public void tag_paragraph()
        {
            HtmlElementCollection ps = d.GetElementsByTagName("p");
            int i = 0;
            foreach (HtmlElement p in ps)
            {
                p.Style = "border:2px dotted red; position: relative;";
                add_label(p, i);
                i++;
            }

        }

        //リストを枠で囲う
        public void tag_list()
        {
            string[] tags = { "ul", "ol", "dl", "dt", "dd" };
            for (int i = 0; i < tags.Length; i++)
            {
                string val = tags[i].ToString();
                _tag_list_func(val);
            }

        }
        private void _tag_list_func(string tag)
        {
            HtmlElementCollection ts = d.GetElementsByTagName(tag);
            int i = 0;
            foreach (HtmlElement t in ts)
            {
                t.Style = "border:2px dotted red; position: relative;";
                add_label(t, i);
                if (tag.Equals("dt"))
                {
                    HtmlElement span = d.GetElementById("bkm-dt-span-" + i);
                    string old_css_text = span.Style;
                    string new_css_text = old_css_text.Replace("left: 2px;", "left: 20px;");
                    span.Style = new_css_text;
                }
                else if (tag.Equals("dd"))
                {
                    HtmlElement span = d.GetElementById("bkm-dd-span-" + i);
                    string old_css_text = span.Style;
                    string new_css_text = old_css_text.Replace("left: 2px;", "left: 20px;");
                    span.Style = new_css_text;
                }
                i++;
            }
        }

        //セマンティック要素を枠で囲う
        public void tag_semantic()
        {
            string[] tags = { "strong", "em" };
            for (int i = 0; i < tags.Length; i++)
            {
                string val = tags[i].ToString();
                _tag_semantic_func(val);
            }
        }
        private void _tag_semantic_func(string tag)
        {
            HtmlElementCollection ts = d.GetElementsByTagName(tag);
            int i = 0;
            foreach (HtmlElement t in ts)
            {
                t.Style = "border:2px dotted red; position: relative;";
                add_label(t, i);
                i++;
            }
        }

        //見出し要素を枠で囲う
        public void tag_heading()
        {
            string[] tags = { "h1", "h2", "h3", "h4", "h5", "h6" };
            for (int i = 0; i < tags.Length; i++)
            {
                string val = tags[i].ToString();
                _tag_semantic_func(val);
            }
        }
        private void _tag_heading_func(string tag)
        {
            HtmlElementCollection ts = d.GetElementsByTagName(tag);
            int i = 0;
            foreach (HtmlElement t in ts)
            {
                t.Style = "border:2px dotted red; position: relative;";
                add_label(t, i);
                i++;
            }
        }

        //テーブル要素を枠で囲う
        public void tag_table()
        {
            _tag_table_table();
            _tag_table_caption();
            _tag_table_th();
        }
        private void _tag_table_table()
        {
            HtmlElementCollection tbls = d.GetElementsByTagName("table");
            int i = 0;
            foreach (HtmlElement tbl in tbls)
            {
                tbl.Style = "border:2px dotted red; position: relative;";
                add_label(tbl, i);
                i++;
            }
            i = 0;
            foreach (HtmlElement tbl in tbls)
            {
                string tbl_tag = tbl.OuterHtml;
                tbl_tag = _text_clean(tbl_tag);
                if (_is_exist_summary_attr(tbl_tag))
                {
                    string smry = tbl.GetAttribute("summary");
                    HtmlElement span = d.GetElementById("bkm-table-span-" + i);
                    string now_label_text = span.InnerHtml;
                    now_label_text = _html_decode(now_label_text);
                    string new_label_text = "";
                    if (smry.Equals("")) new_label_text = now_label_text + ", summary: 空";
                    else new_label_text = now_label_text + ", summary: " + smry;
                    span.InnerText = new_label_text;
                    string old_css_text = span.Style;
                    string new_css_text = old_css_text.Replace("top: 2px;", "top: -20px;");
                    span.Style = new_css_text;
                }
                i++;
            }
        }
        private Boolean _is_exist_summary_attr(string str)
        {
            Regex pt = new Regex(@"summary="".*?""", RegexOptions.IgnoreCase);
            if (pt.IsMatch(str)) return true;
            else return false;
        }
        private void _tag_table_caption()
        {
            HtmlElementCollection cps = d.GetElementsByTagName("caption");
            int i = 0;
            foreach (HtmlElement cp in cps)
            {
                cp.Style = "border:2px dotted red; position: relative;";
                add_label(cp, i);
                i++;
            }
            i = 0;
            foreach (HtmlElement cp in cps)
            {
                HtmlElement span = d.GetElementById("bkm-caption-span-" + i);
                string old_css_text = span.Style;
                string new_css_text = old_css_text.Replace("top: 2px;", "top: -20px;");
                new_css_text = new_css_text.Replace("left: 2px;", "right: 2px;");
                span.Style = new_css_text;
                i++;
            }
        }
        private void _tag_table_th()
        {
            HtmlElementCollection ths = d.GetElementsByTagName("th");
            int i = 0;
            foreach (HtmlElement th in ths)
            {
                th.Style = "border:2px dotted red; position: relative;";
                add_label(th, i);
                i++;
            }
            i = 0;
            foreach (HtmlElement th in ths)
            {
                string th_tag = th.OuterHtml;
                th_tag = _text_clean(th_tag);

                string new_label_text = "";

                if (_is_exist_scope_attr(th_tag))
                {
                    string scope = th.GetAttribute("scope");
                    HtmlElement span = d.GetElementById("bkm-th-span-" + i);
                    string now_label_text = span.InnerHtml;
                    if (scope.Equals("")) new_label_text = now_label_text + ", scope: 空";
                    else new_label_text = now_label_text + ", scope: " + scope;
                    span.InnerHtml = new_label_text;
                }
                i++;
            }
        }
        private Boolean _is_exist_scope_attr(string str)
        {
            Regex pt = new Regex(@"scope="".*?""", RegexOptions.IgnoreCase);
            if (pt.IsMatch(str)) return true;
            else return false;
        }

        //ラベル要素を枠で表示する
        public void tag_label()
        {
            _tag_label_label();
            _tag_label_input();
            _tag_label_textarea();
            _tag_label_select();
        }

        private void _tag_label_label()
        {
            HtmlElementCollection lbs = d.GetElementsByTagName("label");
            int i = 0;
            foreach (HtmlElement lb in lbs)
            {
                string lb_html = lb.OuterHtml;
                lb_html = _text_clean(lb_html);
                lb.Style = "border:2px solid red; position: relative;";
                if (_for_attr_check(lb_html))
                {
                    HtmlElement span = d.CreateElement("span");
                    span.Id = "bmk-label-span-" + i;
                    if (!_label_not_empty(lb_html))
                    {
                        span.Style = "padding-right:5px;color:#fff;font-size:12px;padding:1px;background:#C00000;";
                    }
                    else
                    {
                        span.Style = "padding-right:5px;color:#fff;font-size:12px;padding:1px;background:#600060;";
                    }
                    string for_attr_str = _get_for_attr_val(lb_html);
                    string in_html_str = "";
                    in_html_str += "for属性有: " + for_attr_str;
                    if (!_label_not_empty(lb_html)) in_html_str = "中身無し, " + in_html_str;
                    span.InnerHtml = in_html_str;
                    lb.InsertAdjacentElement(HtmlElementInsertionOrientation.BeforeBegin, span);
                }
                i++;
            }
        }
        private void _tag_label_input()
        {
            HtmlElementCollection ips = d.GetElementsByTagName("input");
            int i = 0;
            foreach (HtmlElement ip in ips)
            {
                string ip_html = ip.OuterHtml;
                ip_html = _text_clean(ip_html);
                string typeattr = ip.GetAttribute("type");
                if (typeattr == "text" || typeattr == "radio" || typeattr == "checkbox")
                {
                    ip.Style = "border:2px solid blue; position: relative;";
                    if (_id_attr_check(ip_html))
                    {
                        HtmlElement span = d.CreateElement("span");
                        span.Id = "bkm-input-span-" + i;
                        string id_attr_str = ip.Id;
                        span.InnerHtml = "id属性有: " + id_attr_str;
                        span.Style = "padding-right:5px;color:#fff;font-size:12px;padding:1px;background:#600060;";
                        ip.InsertAdjacentElement(HtmlElementInsertionOrientation.BeforeBegin, span);
                    }
                }
                i++;
            }

        }
        private void _tag_label_textarea()
        {
            HtmlElementCollection tas = d.GetElementsByTagName("textarea");
            int i = 0;
            foreach (HtmlElement ta in tas)
            {
                string ta_html = ta.OuterHtml;
                ta_html = _text_clean(ta_html);
                ta.Style = "border:2px solid blue; position: relative;";
                if (_id_attr_check(ta_html))
                {
                    HtmlElement span = d.CreateElement("span");
                    span.Id = "bkm-textarea-span-" + i;
                    string id_attr_str = ta.Id;
                    span.InnerHtml = "id属性有: " + id_attr_str;
                    span.Style = "padding-right:5px;color:#fff;font-size:12px;padding:1px;background:#600060;";
                    ta.InsertAdjacentElement(HtmlElementInsertionOrientation.BeforeBegin, span);
                }
                i++;
            }

        }
        private void _tag_label_select()
        {
            HtmlElementCollection sls = d.GetElementsByTagName("select");
            int i = 0;
            foreach (HtmlElement sl in sls)
            {
                string sl_html = sl.OuterHtml;
                sl_html = _text_clean(sl_html);
                sl.Style = "border:2px solid blue; position: relative;";
                if (_id_attr_check(sl_html))
                {
                    HtmlElement span = d.CreateElement("span");
                    span.Id = "bkm-select-span-" + i;
                    string id_attr_str = sl.Id;
                    span.InnerHtml = "id属性有: " + id_attr_str;
                    span.Style = "padding-right:5px;color:#fff;font-size:12px;padding:1px;background:#600060;";
                    sl.InsertAdjacentElement(HtmlElementInsertionOrientation.BeforeBegin, span);
                }
                i++;
            }

        }

        private Boolean _for_attr_check(string str)
        {
            Regex pt = new Regex(@"for="".*?""", RegexOptions.IgnoreCase);
            if (pt.IsMatch(str)) return true;
            else return false;
        }
        private string _get_for_attr_val(string str)
        {
            Regex pt = new Regex(@"for=""(.+?)\""");
            MatchCollection mt = pt.Matches(str);
            if (mt.Count > 0)
            {
                Match m = mt[0];
                return m.Groups[1].Value;
            }
            else
            {
                return null;
            }
        }
        private Boolean _label_not_empty(string str)
        {
            Regex pt = new Regex(@"(<label.*?>)(.+?)(</label>)", RegexOptions.IgnoreCase);
            if (pt.IsMatch(str)) return true;
            else return false;

        }
        private Boolean _id_attr_check(string str)
        {
            Regex pt = new Regex(@"id="".*?""", RegexOptions.IgnoreCase);
            if (pt.IsMatch(str)) return true;
            else return false;
        }

        //br要素を枠で囲う
        public void tag_br()
        {
            HtmlElementCollection brs = d.GetElementsByTagName("br");
            int i = 0;
            foreach (HtmlElement br in brs)
            {
                br.Style = "border:2px dotted red;position: relative;";
                i++;
            }
        }

        private string _text_clean(string str)
        {
            str = Regex.Replace(str, @"^ +", "", RegexOptions.Multiline);
            str = Regex.Replace(str, @"\t+", "", RegexOptions.Multiline);
            str = Regex.Replace(str, @"(\r\n|\r|\n)", "", RegexOptions.Multiline);
            return str;
        }

        private string _html_decode(string str)
        {
            str = Regex.Replace(str, @"&lt;", "<");
            str = Regex.Replace(str, @"&gt;", ">");
            return str;
        }

        private string _html_encode(string str)
        {
            str = Regex.Replace(str, @"<", "&lt;");
            str = Regex.Replace(str, @">", "&gt;");
            return str;
        }


        //要素名ラベルを表示
        private void add_label(HtmlElement obj, int cnt)
        {
            HtmlElement span = d.CreateElement("span");
            string tag_name = obj.TagName;
            tag_name = tag_name.ToLower();
            string span_id = "bkm-" + tag_name + "-span-" + cnt;
            string css_txt = "color:#000;font-size:12px;opacity:0.8;display:block;border:1px solid red;padding:1px;background:yellow;position:absolute;top:2px;left:2px;text-indent:0!important;";
            span.InnerHtml = "&lt;" + tag_name + "&gt;";
            span.Id = span_id;
            span.Style = css_txt;
            obj.AppendChild(span);
        }

    }
}
