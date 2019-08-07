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
                p.Style = "border:1px solid #3A87AD; position: relative;";
                add_label(p, i, "afterbegin", "#3A87AD");
                i++;
            }

        }

        //br要素を枠で囲う
        public void tag_br()
        {
            HtmlElementCollection brs = d.GetElementsByTagName("br");
            int i = 0;
            foreach (HtmlElement br in brs)
            {
                HtmlElement span = d.CreateElement("span");
                string span_id = "bkm-br-span-" + i;
                string css_txt = "color:#fff;font-size:90%!important;padding:1px;border-radius:3px;";
                span.Id = span_id;
                span.Style = css_txt;
                br.InsertAdjacentElement(HtmlElementInsertionOrientation.BeforeBegin, span);
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
                t.Style = "border:1px solid #468847; position: relative;";
                add_label(t, i, "afterbegin", "#468847");
                i++;
            }
        }

        //セマンティック要素を枠で囲う
        public void tag_semantic()
        {
            string[] tags = { "strong", "em", "address", "nav", "section" };
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
                t.Style = "border:1px solid #808080; position: relative;";
                add_label(t, i, "afterbegin", "#888888");
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
                _tag_heading_func(val);
            }
        }
        private void _tag_heading_func(string tag)
        {
            HtmlElementCollection ts = d.GetElementsByTagName(tag);
            int i = 0;
            foreach (HtmlElement t in ts)
            {
                t.Style = "border:1px solid red; position: relative;";
                add_label(t, i, "afterbegin", "#B94A48");
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
                tbl.Style = "border:2px solid red!important; position: relative;";
                add_label(tbl, i, "beforebegin", "#800000");
                i++;
            }
            i = 0;
            foreach (HtmlElement tbl in tbls)
            {
                string smry = tbl.GetAttribute("summary");
                HtmlElement span = d.GetElementById("bkm-table-span-" + i);
                string now_label_text = span.InnerHtml;
                string new_label_text = (smry.Equals("") == true) ? now_label_text : now_label_text + ", summary:" + smry;
                span.InnerHtml = new_label_text;
                i++;
            }
        }
        private void _tag_table_caption()
        {
            HtmlElementCollection cps = d.GetElementsByTagName("caption");
            int i = 0;
            foreach (HtmlElement cp in cps)
            {
                cp.Style = "border:1px solid red!important; position: relative;";
                add_label(cp, i, "afterbegin", "#800000");
                i++;
            }
        }
        private void _tag_table_th()
        {
            HtmlElementCollection ths = d.GetElementsByTagName("th");
            int i = 0;
            foreach (HtmlElement th in ths)
            {
                th.Style = "border:2px solid red!important; position: relative;";
                add_label(th, i, "afterbegin", "#800000");
                i++;
            }
            i = 0;
            foreach (HtmlElement th in ths)
            {
                string scope = th.GetAttribute("scope");
                HtmlElement span = d.GetElementById("bkm-th-span-" + i);
                string now_label_text = span.InnerHtml;
                string new_label_text = (scope.Equals("") == true) ? now_label_text : now_label_text + ", scope:" + scope;
                span.InnerHtml = new_label_text;
                i++;
            }
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
                lb.Style = "border:1px solid #468847!important; position: relative;";
                string span_html = "";
                string span_style = "";
                string span_id = "bkm-label-span-" + i;
                string type = "";
                if(_has_attribute(lb_html, "for"))
                {
                    type = "for-is-yes";
                    span_style = "padding-right:5px;color:#fff;font-size:12px;padding:1px;background:#008000;border-radius:5px;";
                }
                else
                {
                    type = "for-is-no";
                    span_style = "padding-right:5px;color:#fff;font-size:12px;padding:1px;background:#C00000;border-radius:5px;";
                }
                if (type.Equals("for-is-yes"))
                {
                    string for_vl = _get_attribute(lb_html, "for");
                    span_html = (for_vl.Equals("") == true) ? "for属性有:(空)" : "for属性有:" + for_vl;
                    span_html = "&lt;" + lb.TagName.ToLower() + "&gt; , " + span_html;
                }
                else if(type.Equals("for-is-no"))
                {
                    span_html = "&lt;" + lb.TagName.ToLower() + "&gt; , for属性なし";
                }
                HtmlElement span = d.CreateElement("span");
                span.Id = span_id;
                span.Style = span_style;
                span.InnerHtml = span_html;
                lb.InsertAdjacentElement(HtmlElementInsertionOrientation.AfterBegin, span);
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
                string span_html = "";
                string span_style = "";
                string span_id = "bkm-input-span-" + i;
                ip.Style = "border:1px solid blue; position: relative;";
                string type = "";
                Regex pt = new Regex(@"type=""*hidden""*");
                if (pt.IsMatch(ip_html)) continue;

                if (_has_attribute(ip_html, "id"))
                {
                    type = "id-yes";
                    span_style = "padding-right:5px;color:#fff;font-size:12px;padding:1px;background:#3A87AD;border-radius:5px;";
                }
                else
                {
                    type = "id-no";
                    span_style = "padding-right:5px;color:#fff;font-size:12px;padding:1px;background:#C00000;border-radius:5px;";
                }
                if(type.Equals("id-yes"))
                {
                    string id_vl = _get_attribute(ip_html, "id");
                    span_html = (id_vl.Equals("") == true) ? "id属性有:(空)" : "id属性有: " + id_vl;
                } else if (type.Equals("id-no"))
                {
                    span_html = "id属性なし";
                }
                HtmlElement span = d.CreateElement("span");
                span.Id = span_id;
                span.Style = span_style;
                span.InnerHtml = span_html;
                ip.InsertAdjacentElement(HtmlElementInsertionOrientation.BeforeBegin, span);
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
                ta.Style = "border:1px solid blue; position: relative;";
                string span_html = "";
                string span_style = "";
                string span_id = "bkm-textarea-span-" + i;
                string type = "";
                if (_has_attribute(ta_html, "id"))
                {
                    type = "id-yes";
                    span_style = "padding-right:5px;color:#fff;font-size:12px;padding:1px;background:#3A87AD;border-radius:5px;";
                }
                else
                {
                    type = "id-no";
                    span_style = "padding-right:5px;color:#fff;font-size:12px;padding:1px;background:#C00000;border-radius:5px;";
                }
                if (type.Equals("id-yes"))
                {
                    string id_vl = _get_attribute(ta_html, "id");
                    span_html = (id_vl.Equals("") == true) ? "id属性有:(空)" : "id属性有: " + id_vl;
                }
                else if (type.Equals("id-no"))
                {
                    span_html = "id属性なし";
                }
                HtmlElement span = d.CreateElement("span");
                span.Id = span_id;
                span.Style = span_style;
                span.InnerHtml = span_html;
                ta.InsertAdjacentElement(HtmlElementInsertionOrientation.BeforeBegin, span);
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
                sl.Style = "border:1px solid blue; position: relative;";
                string span_html = "";
                string span_style = "";
                string span_id = "bkm-select-span-" + i;
                string type = "";
                if (_has_attribute(sl_html, "id"))
                {
                    type = "id-yes";
                    span_style = "padding-right:5px;color:#fff;font-size:12px;padding:1px;background:#3A87AD;border-radius:5px;";
                }
                else
                {
                    type = "id-no";
                    span_style = "padding-right:5px;color:#fff;font-size:12px;padding:1px;background:#C00000;border-radius:5px;";
                }
                if (type.Equals("id-yes"))
                {
                    string id_vl = _get_attribute(sl_html, "id");
                    span_html = (id_vl.Equals("") == true) ? "id属性有:(空)" : "id属性有: " + id_vl;
                }
                else if (type.Equals("id-no"))
                {
                    span_html = "id属性なし";
                }
                HtmlElement span = d.CreateElement("span");
                span.Id = span_id;
                span.Style = span_style;
                span.InnerHtml = span_html;
                sl.InsertAdjacentElement(HtmlElementInsertionOrientation.BeforeBegin, span);
                i++;
            }

        }

        //title属性を表示する
        public void attr_title()
        {
            string[] tags = { "a", "input", "textarea", "select" };
            for(int i=0; i<tags.Length; i++)
            {
                string val = tags[i].ToString();
                _title_attr_func(val);
            }
        }
        private void _title_attr_func(string tag)
        {
            HtmlElementCollection ts = d.GetElementsByTagName(tag);
            int i = 0;
            foreach(HtmlElement t in ts)
            {
                string t_html = t.OuterHtml;
                t_html = _text_clean(t_html);
                var tag_name = t.TagName.ToLower();
                if (tag_name.Equals("input"))
                {

                    string span_html = "";
                    string span_style = "";
                    string span_id = "bkm-title-attr-span-" + i;
                    string type = "";
                    Regex pt = new Regex(@"type=""*hidden""*");
                    if (pt.IsMatch(t_html)) continue;
                    if (_has_attribute(t_html, "title"))
                    {
                        type = "title-yes";
                        span_style = "padding-right:5px;color:#fff;font-size:12px;padding:1px;background:#008000;border-radius:5px;";
                    }
                    else
                    {
                        type = "title-no";
                        span_style = "padding-right:5px;color:#fff;font-size:12px;padding:1px;background:#C00000;border-radius:5px;";
                    }
                    if (type.Equals("title-yes"))
                    {
                        string title_vl = _get_attribute(t_html, "title");
                        span_html = (title_vl.Equals("") == true) ? "title属性有:(空)" : "title属性有: " + title_vl;
                    }
                    else if (type.Equals("title-no"))
                    {
                        span_html = "title属性なし";
                    }
                    HtmlElement span = d.CreateElement("span");
                    span.Id = span_id;
                    span.Style = span_style;
                    span.InnerHtml = span_html;
                    t.InsertAdjacentElement(HtmlElementInsertionOrientation.BeforeBegin, span);
                    i++;
                }
                else if(tag_name.Equals("textarea") || tag_name.Equals("select"))
                {
                    string span_html = "";
                    string span_style = "";
                    string span_id = "bkm-title-attr-span-" + i;
                    string type = "";
                    if (_has_attribute(t_html, "title"))
                    {
                        type = "title-yes";
                        span_style = "padding-right:5px;color:#fff;font-size:12px;padding:1px;background:#008000;border-radius:5px;";
                    }
                    else
                    {
                        type = "title-no";
                        span_style = "padding-right:5px;color:#fff;font-size:12px;padding:1px;background:#C00000;border-radius:5px;";
                    }
                    if (type.Equals("title-yes"))
                    {
                        string title_vl = _get_attribute(t_html, "title");
                        span_html = (title_vl.Equals("") == true) ? "title属性有:(空)" : "title属性有: " + title_vl;
                    }
                    else if (type.Equals("title-no"))
                    {
                        span_html = "title属性なし";
                    }
                    HtmlElement span = d.CreateElement("span");
                    span.Id = span_id;
                    span.Style = span_style;
                    span.InnerHtml = span_html;
                    t.InsertAdjacentElement(HtmlElementInsertionOrientation.BeforeBegin, span);
                    i++;
                }
                else
                {
                    string span_html = "";
                    string span_style = "";
                    string span_id = "bkm-title-attr-span-" + i;
                    if(_has_attribute(t_html, "title"))
                    {
                        string title_vl = _get_attribute(t_html, "title");
                        span_style = "padding-right:5px;color:#fff;font-size:12px;padding:1px;background:#008000;border-radius:5px;";
                        span_html = (title_vl.Equals("") == true) ? "title属性有:(空)" : "title属性有: " + title_vl;
                        HtmlElement span = d.CreateElement("span");
                        span.Id = span_id;
                        span.Style = span_style;
                        span.InnerHtml = span_html;
                        t.InsertAdjacentElement(HtmlElementInsertionOrientation.BeforeBegin, span);
                        i++;
                    }
                }
            }

        }

        //属性の有無判定
        private Boolean _has_attribute(string html, string attr)
        {
            Boolean flg = false;
            Regex pt1 = new Regex(attr + @"="".*?""");
            Regex pt2 = new Regex(attr + "=");
            if (pt1.IsMatch(html)) flg = true;
            if (pt2.IsMatch(html)) flg = true;
            return flg;
        }

        //属性値の取得
        private string _get_attribute(string html, string attr)
        {
            Regex pt = new Regex(attr + @"=([a-zA-Z0-9\-_]+) *");
            MatchCollection mt = pt.Matches(html);
            if(mt.Count > 0)
            {
                return mt[0].Groups[1].Value;
            }
            else
            {
                return "";
            }
        }

        //テキスト処理
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
        private void add_label(HtmlElement obj, int cnt, string pos, string colorcode)
        {
            HtmlElement span = d.CreateElement("span");
            string tag_name = obj.TagName;
            tag_name = tag_name.ToLower();
            string span_id = "bkm-" + tag_name + "-span-" + cnt;
            string css_txt = "color:#fff;font-size:90%!important;font-weight:normal!important;padding:1px;border-radius:3px;";
            css_txt += "background:" + colorcode + ";";
            string html_str = "&lt;" + tag_name + "&gt;";
            span.InnerHtml = html_str;
            span.Id = span_id;
            span.Style = css_txt;
            switch (pos){
                case "afterbegin":
                    obj.InsertAdjacentElement(HtmlElementInsertionOrientation.AfterBegin, span);
                    break;
                case "afterend":
                    obj.InsertAdjacentElement(HtmlElementInsertionOrientation.AfterEnd, span);
                    break;
                case "beforebegin":
                    obj.InsertAdjacentElement(HtmlElementInsertionOrientation.BeforeBegin, span);
                    break;
                case "beforeend":
                    obj.InsertAdjacentElement(HtmlElementInsertionOrientation.BeforeEnd, span);
                    break;
            }
        }

    }
}
