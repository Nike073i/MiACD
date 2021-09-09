<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet version="1.0"
   xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:template match="/">
        <html>
        <body>
            <h2>Мой автопарк</h2>
            <table border="1">
                <tr bgcolor="#9acd32">
                    <th>Марка</th>
                    <th>Модель</th>
                    <th>Год</th>
                    <th>Пробег</th>
                </tr>
                <xsl:for-each select="park/car">
                    <tr>
                        <td><xsl:value-of select="brand"/></td>
                        <td><xsl:value-of select="model"/></td>
                        <td><xsl:value-of select="year"/></td>
                        <td><xsl:value-of select="mileage"/></td>
                    </tr>
                </xsl:for-each>
            </table>
        </body>
        </html>
    </xsl:template>
</xsl:stylesheet>
