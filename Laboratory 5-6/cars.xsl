<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:template match="/">
        <html>
            <body>
                <h2><u><i>Машины:</i></u></h2>
                <table border="1" cols="5" cellpadding="10">
                    <tr bgcolor="#ff6600">
                        <th>Марка</th>
                        <th>Модель</th>
                        <th>Год</th>
                        <th>Пробег</th>
                        <th>VIN</th>
                    </tr>
                    <xsl:for-each select="cars/car">
                        <xsl:sort select="brand"/>
                        <tr>
                            <td><xsl:value-of select="brand"/></td>
                            <td><xsl:value-of select="model"/></td>
                            <td><xsl:value-of select="production_year"/></td>
                            <td><xsl:value-of select="mileage"/></td>
                            <td><xsl:value-of select="vin_num"/></td>
                        </tr>
                    </xsl:for-each>
                </table>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>
