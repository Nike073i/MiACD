<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:template match="/">
        <html>
            <body>
                <h2>
                    <u>
                        <i>Доступы:</i>
                    </u>
                </h2>
                <table border="1" cols="4" cellpadding="10">
                    <tr bgcolor="#ff6600">
                        <th>car_id</th>
                        <th>driver_id</th>
                        <th>Дата начала</th>
                        <th>Дата конца</th>
                    </tr>
                    <xsl:for-each select="accesses/car_driver_access">
                        <xsl:sort select="car_id"/>
                        <tr>
                            <td>
                                <xsl:value-of select="car_id"/>
                            </td>
                            <td>
                                <xsl:value-of select="driver_id"/>
                            </td>
                            <td>
                                <xsl:value-of select="date_start_use"/>
                            </td>
                            <td>
                                <xsl:choose>
                                    <xsl:when test="date_end_use=''">
                                        Неограниченно
                                    </xsl:when>
                                    <xsl:otherwise>
                                        <xsl:value-of select="date_end_use"/>
                                    </xsl:otherwise>
                                </xsl:choose>
                            </td>
                        </tr>
                    </xsl:for-each>
                </table>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>