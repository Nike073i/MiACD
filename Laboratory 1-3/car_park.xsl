<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet version="1.0"
   xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:template match="/">
        <html>
        <body>
            <h2><u><i>Мой автопарк</i></u></h2>
            <table border="1" cols="4" cellpadding="10">
                <tr bgcolor="#ff6600">
                    <th>Марка</th>
                    <th>Модель</th>
                    <th>Год</th>
                    <th>Пробег</th>
                </tr>
                <xsl:for-each select="park/car">
                    <xsl:sort select="brand"/>
                    <tr>
                        <td><xsl:value-of select="brand"/></td>
                        <td><xsl:value-of select="model"/></td>
                        <xsl:choose>
                            <xsl:when test="year=2013">
                                <td><b><xsl:value-of select="year"/></b></td>
                            </xsl:when>
                            <xsl:otherwise>
                                <td><xsl:value-of select="year"/></td>
                            </xsl:otherwise>
                        </xsl:choose>
                        <td><xsl:value-of select="mileage"/></td>
                    </tr>
                </xsl:for-each>
            </table>
        </body>
        </html>
    </xsl:template>
</xsl:stylesheet>
