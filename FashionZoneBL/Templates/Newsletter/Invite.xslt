﻿<?xml version="1.0"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="html"/>
  <xsl:template match="/">
    <html>
      <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
        <title>FZone Invite</title>
      </head>
      <body style="margin:0; padding:0; background-color: #e7dcdd;" bgcolor="#e7dcdd">
        <div style="width: 100%; color: #CC3333; font-family:Sans-Serif;  height:auto; margin: 0 auto; background-color: #e7dcdd;">
          <table width="504" cellpadding="0" cellspacing="0" align="center">
            <tr>
              <td width="40%">
                <xsl:if test="string(/Root/Url) != ''">
                  <a>
                    <xsl:attribute name="href">
                      <xsl:value-of select="/Root/Url"/>
                    </xsl:attribute>
                    <img style="border: 0; width: 200px; height: 134px;" src="http://www.fzone.al/image/logo_fzone.png"
                      alt="FZone" />
                  </a>
                </xsl:if>
              </td>
              <td width="27%">
              </td>
              <td width="33%" style="text-align: right; vertical-align: center">
                <span style="margin-right: 30px; font-size: 14pt; color: #CC3333; font-family:Sans-Serif;">Kap ofert&#235;n!</span>
              </td>
            </tr>
            <tr>
              <td colspan="3" style="text-align: center; padding-top: 10px;">
                <br />
                <br />
                <span style="font-size: 12pt; color: #CC3333; font-family:Sans-Serif;  font-weight: bold;">Ftes&#235; p&#235;r t&#235; vetmin Club Fashion n&#235; Shqip&#235;ri</span>
                <br />
                <br />
                <br />
                <br />
              </td>
            </tr>
            <tr>
              <td colspan="3">
                <span style="font-size: 10pt; color: #CC3333; font-family:Sans-Serif; ">
                  <xsl:value-of disable-output-escaping="yes" select="/Root/Customer/Name"/>, t&#235; d&#235;rgoi nj&#235; ftes&#235; p&#235;r t&#235; par&#235; markat m&#235; eksluzive n&#235;
                  <xsl:if test="string(/Root/Url) != ''">
                    <a>
                      <xsl:attribute name="href">
                        <xsl:value-of select="/Root/Url"/>
                      </xsl:attribute>www.fzone.al
                    </a>
                  </xsl:if>
                </span>
              </td>
            </tr>
            <tr>
              <td colspan="3">
                <br />
              </td>
            </tr>
            <tr>
              <td colspan="3">
                <hr style="width: 504px; height: 5px; color: #CC3333; margin-top: 10px; background-color: #CC3333;
                        border: 0; text-align: left;" />
              </td>
            </tr>
            <tr>
              <td colspan="3">
                <span style="font-size: 9pt; color: #CC3333; font-family:Sans-Serif;">
                  FZone.al &#235;sht&#235; pjes&#235; e Zone Sh.p.k. Adr. Rr. e Bogdan&#235;ve/Gjon Muzaka nr.1, Tiran&#235;
                  <br />
                  P&#235;r m&#235; shum&#235; info:
                  <xsl:if test="string(/Root/Url) != ''">
                    <a>
                      <xsl:attribute name="href">
                        <xsl:value-of select="/Root/Url"/>
                      </xsl:attribute>www.fzone.al
                    </a>
                  </xsl:if>
                  ose na kontaktoni n&#235; info@fzone.al ose n&#235; 044 530 424
                  <br />
                </span>
              </td>
            </tr>
          </table>
        </div>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>