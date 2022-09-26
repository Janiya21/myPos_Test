import React, { useState, useEffect } from 'react';
import '../assets/itemPage.css'
import {Grid, Table, Form, Input, Statistic, Button, Select, Icon, Image, Segment} from 'semantic-ui-react'

const ItemPage = () => {
    const [loading, setLoading] = useState(false);

    useEffect(() => {
        setLoading(true);
        setTimeout(() => {
            setLoading(false);
        }, 500);
    }, []);

    return (
        <div className="container" >
            {loading ? (
                <div className="loader-container">
                    <div className="spinner"/>
                    <h1 className={"header-shop"}>Loading ...</h1>
                </div>
            ) : (
                <div className="main-content">
                    <Grid>
                        <Grid.Row>
                            <Form style={{marginTop:"30px"}}>
                                <Form.Group widths='equal'>
                                    <Form.Field
                                        id='form-input-control-desc'
                                        control={Input}
                                        label='Product ID'
                                        placeholder='item description'
                                    />
                                    <Form.Field
                                        control={Input}
                                        label='Product name'
                                        placeholder='Product Name'
                                        id='form-input-control-name'
                                    />
                                    <Form.Field style={{width:"21vw"}}
                                                id='form-input-control-qty'
                                                control={Input}
                                                label='Quantity'
                                                placeholder='item quantity'
                                    />
                                    <Form.Field style={{width:"21vw"}}
                                                id='form-input-control-unitPrice'
                                                control={Input}
                                                label='Unit Price'
                                                placeholder='Unit Price'
                                    />
                                </Form.Group>
                                <Form.Group style={{margin:"20px 0 0 0"}}>
                                    <Form.Field
                                        id='form-button-control-public'
                                        control={Button}
                                        content='Save Item'
                                    />
                                    <Form.Field
                                        id='form-button-control-public'
                                        control={Button}
                                        content='Update Item'
                                    />
                                    <Form.Field
                                        id='form-button-control-public'
                                        control={Button}
                                        content='Clear'
                                    />
                                </Form.Group>
                            </Form>
                        </Grid.Row>
                        <Grid.Row>
                            asfasf
                        </Grid.Row>
                    </Grid>
                </div>
            )}
        </div>
    );
}

export default ItemPage;