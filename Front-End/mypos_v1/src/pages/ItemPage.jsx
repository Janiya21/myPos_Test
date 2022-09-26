import React, { useState, useEffect } from 'react';
import '../assets/itemPage.css'
import {Grid, Table, Form, Input, Statistic, Button, Select, Icon, Image, Segment} from 'semantic-ui-react'
import Navbar from './navbar';

const ItemPage = () => {
    const [loading, setLoading] = useState(false);

    useEffect(() => {
        setLoading(true);
        setTimeout(() => {
            setLoading(false);
        }, 500);
    }, []);

    return (
        // style={{height:"100vh",backgroundImage:'url("https://www.hotshot-sports.com/wp-content/uploads/multisports_650017870.jpg',backgroundRepeat:"no-repeat, repeat"}}
        <div className="container" >
            {loading ? (
                <div className="loader-container">
                    <div className="spinner"/>
                    <h1 className={"header-shop"}>My POS Software ...</h1>
                    {/*<img className={"load-image"} src={"https://www.freepnglogos.com/uploads/sport-png/sport-steadman-philippon-institute-official-site-16.png"} alt={"s"}/>*/}
                </div>
            ) : (
                <div className="main-content">
                    <Grid >
                        <Grid.Column width={7} style={{ margin: "70px 0 0 10px" }}>
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
                                </Form.Group>
                                <Form.Group >
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
                        </Grid.Column>
                        <Grid.Column width={8} style={{margin:"50px 0 0 20px"}}>
                            <Input icon='search' placeholder='Search...' style={{width:"49vw", margin:"20px 0 20px 0"}}/>
                            <Table celled selectable>
                                <Table.Header>
                                    <Table.Row>
                                        <Table.HeaderCell>Product ID</Table.HeaderCell>
                                        <Table.HeaderCell>Product Name</Table.HeaderCell>
                                        <Table.HeaderCell>Qty</Table.HeaderCell>
                                        <Table.HeaderCell>Unit Price</Table.HeaderCell>
                                    </Table.Row>
                                </Table.Header>

                                <Table.Body>
                                    <Table.Row>
                                        <Table.Cell>Product ID</Table.Cell>
                                        <Table.Cell>Product Name</Table.Cell>
                                        <Table.Cell>Qty</Table.Cell>
                                        <Table.Cell>Unit Price</Table.Cell>
                                    </Table.Row>
                                    <Table.Row>
                                        <Table.Cell>Jamie</Table.Cell>
                                        <Table.Cell>Approved</Table.Cell>
                                        <Table.Cell>Requires call</Table.Cell>
                                        <Table.Cell>Unit Price</Table.Cell>
                                    </Table.Row>
                                    <Table.Row>
                                        <Table.Cell>Jill</Table.Cell>
                                        <Table.Cell>Denied</Table.Cell>
                                        <Table.Cell>None</Table.Cell>
                                        <Table.Cell>Unit Price</Table.Cell>
                                    </Table.Row>
                                    <Table.Row >
                                        <Table.Cell>John</Table.Cell>
                                        <Table.Cell>No Action</Table.Cell>
                                        <Table.Cell>None</Table.Cell>
                                        <Table.Cell>Unit Price</Table.Cell>
                                    </Table.Row>
                                    <Table.Row>
                                        <Table.Cell>Jamie</Table.Cell>
                                        <Table.Cell >Approved</Table.Cell>
                                        <Table.Cell >Requires call</Table.Cell>
                                        <Table.Cell>Unit Price</Table.Cell>
                                    </Table.Row>
                                    <Table.Row>
                                        <Table.Cell>Jill</Table.Cell>
                                        <Table.Cell >Denied</Table.Cell>
                                        <Table.Cell>None</Table.Cell>
                                        <Table.Cell>Unit Price</Table.Cell>
                                    </Table.Row>
                                </Table.Body>
                            </Table>
                        </Grid.Column>
                    </Grid>
                </div>
            )}
        </div>
    );
}

export default ItemPage;